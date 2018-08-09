// ------------------------------------------------------------------------------------------------
//  <copyright file="SteamNewsBuilderHandler .cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Fluent.General
{
    using System;
    using System.ComponentModel;
    using Interfaces.General.ISteamNews;
    using Interfaces.General.ISteamNews.GetNewsForApp;
    using ISteamNews;

    public class SteamNewsBuilderHandler : SteamBaseBuilderHandler
    {
        public SteamNewsBuilderHandler(string key) : base(key)
        {
        }

        /// <summary>
        ///     News feed for various games.
        /// </summary>
        /// <param name="gameType">The game/item to retrieve news for. This can be any valid app ID as seen in the Steam store.</param>
        /// <returns></returns>
        public GetNewsForAppBuilder GetNewsForApp(GameType gameType)
        {
            return this.GetNewsForApp((int) gameType);
        }

        /// <summary>
        ///     News feed for various games.
        /// </summary>
        /// <param name="appID">The game/item to retrieve news for. This can be any valid app ID as seen in the Steam store.</param>
        /// <returns></returns>
        public GetNewsForAppBuilder GetNewsForApp(int appID)
        {
            return new GetNewsForAppBuilder(new GetNewsForAppRequest(this.Key) {AppID = appID});
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

        [EditorBrowsable(EditorBrowsableState.Never)]
        public new Type GetType()
        {
            return this.GetType();
        }
    }
}