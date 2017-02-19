namespace PortableSteam.Fluent.General.ISteamApps
{
    using PortableSteam.Interfaces.General.ISteamApps;
    using System;
    using System.ComponentModel;

    public class UpToDateCheckBuilder : SteamBaseBuilder<UpToDateCheckRequest, UpToDateCheckResponse, UpToDateCheckBuilder>
    {
        public UpToDateCheckBuilder(UpToDateCheckRequest request) : base(request) { }

        public UpToDateCheckBuilder Test()
        {
            return this;
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
