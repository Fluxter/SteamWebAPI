namespace PortableSteam.Fluent.General.ISteamUserStats
{
    using PortableSteam.Infrastructure;
    using PortableSteam.Interfaces.General.ISteamUserStats;
    using System;
    using System.ComponentModel;

    public class GetSchemaForGameBuilder : SteamBaseBuilder<GetSchemaForGameRequest, GetSchemaForGameResponse, GetSchemaForGameBuilder>
    {
        public GetSchemaForGameBuilder(GetSchemaForGameRequest request) : base(request) { }

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
