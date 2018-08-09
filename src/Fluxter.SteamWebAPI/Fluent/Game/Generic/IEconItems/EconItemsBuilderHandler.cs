// ------------------------------------------------------------------------------------------------
//  <copyright file="EconItemsBuilderHandler.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Fluent.Game
{
    using System;
    using System.ComponentModel;
    using Generic.IEconItems;
    using Interfaces.Game.Generic.IEconItems;
    using Interfaces.Game.Generic.IEconItems.GetPlayerItems;
    using Interfaces.Game.Generic.IEconItems.GetSchema;
    using Interfaces.Game.Generic.IEconItems.GetSchemaURL;
    using Interfaces.Game.Generic.IEconItems.GetStoreMetaData;

    public class EconItemsBuilderHandler : GameBaseBuilderHandler
    {
        /// <summary>
        ///     Constructor.
        /// </summary>
        /// <param name="key"></param>
        public EconItemsBuilderHandler(string key, int appID) : base(key, appID)
        {
        }

        /// <summary>
        ///     Lists items in a player's backpack.
        ///     <param name="identity">The identity of the user the backpack will be retrieved for.</param>
        /// </summary>
        public GetPlayerItemsBuilder GetPlayerItems(SteamIdentity identity)
        {
            return new GetPlayerItemsBuilder(
                new GetPlayerItemsRequest(this.Key, this.AppID) {SteamID = identity.SteamID});
        }

        /// <summary>
        ///     Information about the items in a supporting game.
        /// </summary>
        public GetSchemaBuilder GetSchema()
        {
            return new GetSchemaBuilder(new GetSchemaRequest(this.Key, this.AppID));
        }

        /// <summary>
        ///     Returns a URL for the game's item_game.txt file. This method is not supported on app ids: 260, 620, 710, 841
        /// </summary>
        public GetSchemaURLBuilder GetSchemaURL()
        {
            return new GetSchemaURLBuilder(new GetSchemaURLRequest(this.Key, this.AppID));
        }

        /// <summary>
        ///     Information about the game's store.
        /// </summary>
        public GetStoreMetaDataBuilder GetStoreMetaData()
        {
            return new GetStoreMetaDataBuilder(new GetStoreMetaDataRequest(this.Key, this.AppID));
        }

        /// <summary>
        ///     The game's store status.
        /// </summary>
        public void GetStoreStatus()
        {
            throw new NotImplementedException();
        }

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
    }
}