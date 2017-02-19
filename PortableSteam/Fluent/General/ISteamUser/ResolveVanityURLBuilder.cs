namespace PortableSteam.Fluent.General.ISteamUser
{
    using PortableSteam.Interfaces.General.ISteamUser;
    using System;
    using System.ComponentModel;

    public class ResolveVanityURLBuilder : SteamBaseBuilder<ResolveVanityURLRequest, ResolveVanityURLResponse, ResolveVanityURLBuilder>
    {
        public ResolveVanityURLBuilder(ResolveVanityURLRequest request) : base(request) { }

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
