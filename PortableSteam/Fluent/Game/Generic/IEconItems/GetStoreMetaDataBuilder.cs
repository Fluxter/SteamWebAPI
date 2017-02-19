namespace PortableSteam.Fluent.Game.Generic.IEconItems
{
    using PortableSteam.Fluent;
    using PortableSteam.Interfaces.Game.Generic.IEconItems;
    using System;
    using System.ComponentModel;

    public class GetStoreMetaDataBuilder : SteamBaseBuilder<GetStoreMetaDataRequest, GetStoreMetaDataResponse, GetStoreMetaDataBuilder>
    {
        public GetStoreMetaDataBuilder(GetStoreMetaDataRequest request) : base(request) { }

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
