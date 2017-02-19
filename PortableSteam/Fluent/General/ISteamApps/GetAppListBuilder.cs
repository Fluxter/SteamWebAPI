namespace PortableSteam.Fluent.General.ISteamApps
{
    using PortableSteam.Fluent;
    using PortableSteam.Interfaces.General.ISteamApps;
    using System;
    using System.ComponentModel;

    public class GetAppListBuilder : SteamBaseBuilder<GetAppListRequest, GetAppListResponse, GetAppListBuilder>
    {
        public GetAppListBuilder(GetAppListRequest request) : base(request) { }

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
