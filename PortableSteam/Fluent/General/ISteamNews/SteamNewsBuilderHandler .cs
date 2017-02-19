namespace PortableSteam.Fluent.General
{
    using PortableSteam.Fluent.General.ISteamNews;
    using PortableSteam.Infrastructure;
    using PortableSteam.Interfaces.General.ISteamNews;
    using System;
    using System.ComponentModel;

    public class SteamNewsBuilderHandler : SteamBaseBuilderHandler
    {
        public SteamNewsBuilderHandler(string key) : base(key) { }
        /// <summary>
        /// News feed for various games.
        /// </summary>
        /// <param name="gameType">The game/item to retrieve news for. This can be any valid app ID as seen in the Steam store.</param>
        /// <returns></returns>
        public GetNewsForAppBuilder GetNewsForApp(GameType gameType)
        {
            return this.GetNewsForApp((int)gameType);
        }
        /// <summary>
        /// News feed for various games.
        /// </summary>
        /// <param name="appID">The game/item to retrieve news for. This can be any valid app ID as seen in the Steam store.</param>
        /// <returns></returns>
        public GetNewsForAppBuilder GetNewsForApp(int appID)
        {
            return new GetNewsForAppBuilder(new GetNewsForAppRequest(this.Key) { AppID = appID });
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
