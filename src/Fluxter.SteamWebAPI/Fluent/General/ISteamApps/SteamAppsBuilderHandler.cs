// ------------------------------------------------------------------------------------------------
//  <copyright file="SteamAppsBuilderHandler.cs"
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
    using Interfaces.General.ISteamApps;
    using Interfaces.General.ISteamApps.GetAppList;
    using Interfaces.General.ISteamApps.UpToDateCheck;
    using ISteamApps;

    public class SteamAppsBuilderHandler : SteamBaseBuilderHandler
    {
        public SteamAppsBuilderHandler(string key) : base(key)
        {
        }

        /// <summary>
        ///     Full list of every publicly facing program in the store/library.
        /// </summary>
        /// <returns></returns>
        public GetAppListBuilder GetAppList()
        {
            return new GetAppListBuilder(new GetAppListRequest(this.Key));
        }

        /// <summary>
        ///     No documentation.
        /// </summary>
        /// <returns></returns>
        public void GetServersAtAddress()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     Check if a given app version is the most current available.
        /// </summary>
        /// <param name="gameType">Game</param>
        /// <param name="version">The installed version of the game.</param>
        /// <returns></returns>
        public UpToDateCheckBuilder UpToDateCheck(GameType gameType, int version)
        {
            return this.UpToDateCheck((int) gameType, version);
        }

        /// <summary>
        ///     Check if a given app version is the most current available.
        /// </summary>
        /// <param name="appID">AppID of game.</param>
        /// <param name="version">The installed version of the game.</param>
        /// <returns></returns>
        public UpToDateCheckBuilder UpToDateCheck(int appID, int version)
        {
            return new UpToDateCheckBuilder(new UpToDateCheckRequest(this.Key) {AppID = appID, Version = version});
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