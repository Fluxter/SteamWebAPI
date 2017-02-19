namespace PortableSteam.Fluent.General.ISteamWebAPIUtil
{
    using Newtonsoft.Json;
    using PortableSteam.Infrastructure;
    using PortableSteam.Interfaces.General.ISteamWebAPIUtil;
    using System;
    using System.ComponentModel;

    public class GetServerInfoBuilder : SteamBaseBuilder<GetServerInfoRequest, GetServerInfoResponse, GetServerInfoBuilder>
    {
        public GetServerInfoBuilder(GetServerInfoRequest request) : base(request) { }

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
