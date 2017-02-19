namespace PortableSteam.Fluent.General
{
    using PortableSteam.Fluent.General.ISteamWebAPIUtil;
    using PortableSteam.Infrastructure;
    using PortableSteam.Interfaces.General.ISteamWebAPIUtil;
    using System;
    using System.ComponentModel;

    public class SteamWebAPIUtilBuilderHandler : SteamBaseBuilderHandler
    {
        public SteamWebAPIUtilBuilderHandler(string key) : base(key) { }
        /// <summary>
        /// Returns WebAPI server time and checks server status.
        /// </summary>
        /// <returns></returns>
        public GetServerInfoBuilder GetServerInfo()
        {
            return new GetServerInfoBuilder(new GetServerInfoRequest(this.Key));
        }
        /// <summary>
        /// Lists all available WebAPI interfaces.
        /// </summary>
        /// <returns></returns>
        public GetSupportedAPIListBuilder GetSupportedAPIList()
        {
            return new GetSupportedAPIListBuilder(new GetSupportedAPIListRequest(this.Key));
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
