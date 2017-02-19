namespace PortableSteam.Fluent.Game
{
    using PortableSteam.Fluent.Game.Generic.IEconItems;
    using PortableSteam.Infrastructure;
    using PortableSteam.Interfaces.Game.Generic.IEconItems;
    using System;
    using System.ComponentModel;

    public class EconItemsBuilderHandler : GameBaseBuilderHandler
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="key"></param>
        public EconItemsBuilderHandler(string key, int appID) : base(key, appID) { }
        /// <summary>
        /// Lists items in a player's backpack.
        /// <param name="identity">The identity of the user the backpack will be retrieved for.</param>
        /// </summary>
        public GetPlayerItemsBuilder GetPlayerItems(SteamIdentity identity)
        {
            return new GetPlayerItemsBuilder(new GetPlayerItemsRequest(this.Key, this.AppID) { SteamID = identity.SteamID });
        }
        /// <summary>
        /// Information about the items in a supporting game.
        /// </summary>
        public GetSchemaBuilder GetSchema()
        {
            return new GetSchemaBuilder(new GetSchemaRequest(this.Key, this.AppID));
        }
        /// <summary>
        /// Returns a URL for the game's item_game.txt file. This method is not supported on app ids: 260, 620, 710, 841
        /// </summary>
        public GetSchemaURLBuilder GetSchemaURL()
        {
            return new GetSchemaURLBuilder(new GetSchemaURLRequest(this.Key, this.AppID));
        }
        /// <summary>
        /// Information about the game's store.
        /// </summary>
        public GetStoreMetaDataBuilder GetStoreMetaData()
        {
            return new GetStoreMetaDataBuilder(new GetStoreMetaDataRequest(this.Key, this.AppID));
        }
        /// <summary>
        /// The game's store status.
        /// </summary>
        public void GetStoreStatus()
        {
            throw new NotImplementedException();
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
