// ------------------------------------------------------------------------------------------------
//  <copyright file="GCVersionBuilderHandler.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Fluent.Game
{
    using System;
    using System.ComponentModel;

    public class GCVersionBuilderHandler : GameBaseBuilderHandler
    {
        /// <summary>
        ///     Constructor.
        /// </summary>
        /// <param name="key"></param>
        public GCVersionBuilderHandler(string key, int appID) : base(key, appID)
        {
        }

        /// <summary>
        ///     TODO.
        /// </summary>
        public void GetClientVersion()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     TODO.
        /// </summary>
        public void GetClusterVersion()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     TODO.
        /// </summary>
        public void GetServerVersion()
        {
            throw new NotImplementedException();
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override string ToString()
        {
            return base.ToString();
        }
    }
}