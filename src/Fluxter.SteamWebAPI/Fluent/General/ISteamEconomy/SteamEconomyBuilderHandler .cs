// ------------------------------------------------------------------------------------------------
//  <copyright file="SteamEconomyBuilderHandler .cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Fluent.General
{
    using System;
    using System.ComponentModel;
    using Interfaces.General.ISteamEconomy;
    using Interfaces.General.ISteamEconomy.GetAssetClassInfo;
    using Interfaces.General.ISteamEconomy.GetAssetPrices;
    using ISteamEconomy;

    public class SteamEconomyBuilderHandler : SteamBaseBuilderHandler
    {
        public SteamEconomyBuilderHandler(string key) : base(key)
        {
        }

        /// <summary>
        ///     Asset metadata.
        /// </summary>
        /// <param name="gameType">Game to query assets from.</param>
        /// <param name="classCount">The number of classids passed to the request.</param>
        /// <param name="classIDs">A series of numbers to form a list of class IDs.</param>
        /// <returns></returns>
        public GetAssetClassInfoBuilder GetAssetClassInfo(GameType gameType, int classCount, params int[] classIDs)
        {
            return this.GetAssetClassInfo((int) gameType, classCount, classIDs);
        }

        /// <summary>
        ///     Asset metadata.
        /// </summary>
        /// <param name="appID">The ID of the game to query assets from.</param>
        /// <param name="classCount">The number of classids passed to the request.</param>
        /// <param name="classIDs">A series of numbers to form a list of class IDs.</param>
        /// <returns></returns>
        public GetAssetClassInfoBuilder GetAssetClassInfo(int appID, int classCount, params int[] classIDs)
        {
            if (classIDs.Length != classCount)
            {
                throw new ArgumentException("Number of class ID's must match the class count");
            }

            return new GetAssetClassInfoBuilder(
                new GetAssetClassInfoRequest(this.Key) {AppID = appID, ClassCount = classCount, ClassIDs = classIDs});
        }

        /// <summary>
        ///     Prices of items in the economy.
        /// </summary>
        /// <param name="gameType">Game to query assets from.</param>
        /// <returns></returns>
        public GetAssetPricesBuilder GetAssetPrices(GameType gameType)
        {
            return this.GetAssetPrices((int) gameType);
        }

        /// <summary>
        ///     Prices of items in the economy.
        /// </summary>
        /// <param name="appID">The ID of the game to query assets from.</param>
        /// <returns></returns>
        public GetAssetPricesBuilder GetAssetPrices(int appID)
        {
            return new GetAssetPricesBuilder(new GetAssetPricesRequest(this.Key) {AppID = appID});
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