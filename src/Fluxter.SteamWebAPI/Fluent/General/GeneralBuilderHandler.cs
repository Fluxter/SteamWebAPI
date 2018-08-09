// ------------------------------------------------------------------------------------------------
//  <copyright file="GeneralBuilderHandler.cs"
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

    public class GeneralBuilderHandler : SteamBaseBuilderHandler
    {
        /// <summary>
        ///     Constructor.
        /// </summary>
        /// <param name="key"></param>
        public GeneralBuilderHandler(string key) : base(key)
        {
        }

        /// <summary>
        ///     Methods relating to Steam Apps in general.
        /// </summary>
        /// <returns></returns>
        public SteamAppsBuilderHandler ISteamApps()
        {
            return new SteamAppsBuilderHandler(this.Key);
        }

        /// <summary>
        ///     Methods relating to games' store's assets.
        /// </summary>
        /// <returns></returns>
        public SteamEconomyBuilderHandler ISteamEconomy()
        {
            return new SteamEconomyBuilderHandler(this.Key);
        }

        /// <summary>
        ///     Methods relating to Steam News.
        /// </summary>
        /// <returns></returns>
        public SteamNewsBuilderHandler ISteamNews()
        {
            return new SteamNewsBuilderHandler(this.Key);
        }

        /// <summary>
        ///     Methods relating to stored files.
        /// </summary>
        /// <returns></returns>
        public SteamRemoteStorageBuilderHandler ISteamRemoteStorage()
        {
            return new SteamRemoteStorageBuilderHandler(this.Key);
        }

        /// <summary>
        ///     Methods relating to Steam users.
        /// </summary>
        /// <returns></returns>
        public SteamUserBuilderHandler ISteamUser()
        {
            return new SteamUserBuilderHandler(this.Key);
        }

        /// <summary>
        ///     Methods relating to User stats.
        /// </summary>
        /// <returns></returns>
        public SteamUserStatsBuilderHandler ISteamUserStats()
        {
            return new SteamUserStatsBuilderHandler(this.Key);
        }

        /// <summary>
        ///     Methods relating to a Steam user's games.
        /// </summary>
        /// <returns></returns>
        public PlayerServiceBuilderHandler IPlayerService()
        {
            return new PlayerServiceBuilderHandler(this.Key);
        }

        /// <summary>
        ///     Methods relating to the WebAPI itself.
        /// </summary>
        /// <returns></returns>
        public SteamWebAPIUtilBuilderHandler ISteamWebAPIUtil()
        {
            return new SteamWebAPIUtilBuilderHandler(this.Key);
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