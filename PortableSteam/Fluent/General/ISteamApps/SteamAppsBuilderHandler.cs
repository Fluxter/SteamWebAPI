namespace PortableSteam.Fluent.General
{
    using PortableSteam.Fluent.General.ISteamApps;
    using PortableSteam.Interfaces.General.ISteamApps;
    using System;
    using System.ComponentModel;

    public class SteamAppsBuilderHandler : SteamBaseBuilderHandler
    {
        public SteamAppsBuilderHandler(string key) : base(key) { }
        /// <summary>
        /// Full list of every publicly facing program in the store/library.
        /// </summary>
        /// <returns></returns>
        public GetAppListBuilder GetAppList()
        {
            return new GetAppListBuilder(new GetAppListRequest(this.Key));
        }
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <returns></returns>
        public void GetServersAtAddress()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Check if a given app version is the most current available.
        /// </summary>
        /// <param name="gameType">Game</param>
        /// <param name="version">The installed version of the game.</param>
        /// <returns></returns>
        public UpToDateCheckBuilder UpToDateCheck(GameType gameType, int version)
        {
            return this.UpToDateCheck((int)gameType, version);
        }
        /// <summary>
        /// Check if a given app version is the most current available.
        /// </summary>
        /// <param name="appID">AppID of game.</param>
        /// <param name="version">The installed version of the game.</param>
        /// <returns></returns>
        public UpToDateCheckBuilder UpToDateCheck(int appID, int version)
        {
            return new UpToDateCheckBuilder(new UpToDateCheckRequest(this.Key) { AppID = appID, Version = version });
        }

        #region Hidden

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

        #endregion
    }
}
