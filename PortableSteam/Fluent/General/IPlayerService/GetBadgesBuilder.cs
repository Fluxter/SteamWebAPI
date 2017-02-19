namespace PortableSteam.Fluent.General.IPlayerService
{
    using PortableSteam.Fluent;
    using PortableSteam.Interfaces.General.IPlayerService;
    using System;
    using System.ComponentModel;

    public class GetBadgesBuilder : SteamBaseBuilder<GetBadgesRequest, GetBadgesResponse, GetBadgesBuilder>
    {
        public GetBadgesBuilder(GetBadgesRequest request) : base(request) { }

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
