// ------------------------------------------------------------------------------------------------
//  <copyright file="SteamWebAPI.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI
{
    using System;
    using System.ComponentModel;
    using Fluent;
    using Fluent.Game;
    using Fluent.General;
    using Fluent.Other;
    using Infrastructure;
    using Infrastructure.Objects;

    /// <summary>
    ///     Valve provides these APIs so website developers can use data from Steam in new and interesting ways.
    ///     They allow developers to query Steam for information that they can present on their own sites.
    ///     At the moment the only APIs we offer provide item data for Team Fortress 2, but this list will grow over time.
    /// </summary>
    /// <see href="http://steamcommunity.com/dev" />
    /// <see href="http://wiki.teamfortress.com/wiki/WebAPI" />
    public static class SteamWebAPI
    {
        private static string _key;

        /// <summary>
        ///     Sets your Steam Web API key. Without this, the server will return an HTTP 403 (forbidden) error.
        /// </summary>
        /// <param name="key"></param>
        public static void SetGlobalKey(string key)
        {
            _key = key;
        }

        /// <summary>
        ///     Custom steam request.
        /// </summary>
        /// <param name="interface">Interface.</param>
        /// <param name="method">Method's name</param>
        /// <param name="version">Method's version.</param>
        /// <param name="actionBody">QueryStringDictionary action.</param>
        /// <returns></returns>
        public static SteamCustomBuilder CustomRequest(string @interface, string method, string version,
            Action<QueryStringDictionary> actionBody)
        {
            if (string.IsNullOrEmpty(@interface))
            {
                throw new ArgumentNullException("Interface must be supplied.");
            }

            if (string.IsNullOrEmpty(method))
            {
                throw new ArgumentNullException("Method must be supplied.");
            }

            if (string.IsNullOrEmpty(version))
            {
                throw new ArgumentNullException("Version must be supplied.");
            }

            var request = new CustomRequest(_key)
            {
                Interface = @interface,
                Method = method,
                Version = version
            };

            actionBody(request.Parameters);

            return new SteamCustomBuilder(request);
        }

        /// <summary>
        ///     Custom steam request.
        /// </summary>
        /// <param name="interface"></param>
        /// <param name="method"></param>
        /// <param name="version"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static SteamCustomBuilder CustomRequest(string @interface, string method, string version,
            object parameters)
        {
            if (string.IsNullOrEmpty(@interface))
            {
                throw new ArgumentNullException("Interface must be supplied.");
            }

            if (string.IsNullOrEmpty(method))
            {
                throw new ArgumentNullException("Method must be supplied.");
            }

            if (string.IsNullOrEmpty(version))
            {
                throw new ArgumentNullException("Version must be supplied.");
            }

            var request = new CustomRequest(_key)
            {
                Interface = @interface,
                Method = method,
                Version = version,
                Parameters = parameters.ToDictionary()
            };

            return new SteamCustomBuilder(request);
        }

        /// <summary>
        ///     General interfaces.
        /// </summary>
        /// <returns></returns>
        public static GeneralBuilderHandler General()
        {
            return new GeneralBuilderHandler(_key);
        }

        /// <summary>
        ///     Game specific interfaces
        /// </summary>
        /// <returns></returns>
        public static GameBuilderHandler Game()
        {
            return new GameBuilderHandler(_key);
        }

        /// <summary>
        ///     Other undocumented interfaces.
        /// </summary>
        /// <returns></returns>
        public static OtherBuilderHandler Other()
        {
            return new OtherBuilderHandler(_key);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public new static bool ReferenceEquals(object objA, object objB)
        {
            return ReferenceEquals(objA, objB);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public new static bool Equals(object objA, object objB)
        {
            return Equals(objA, objB);
        }
    }
}