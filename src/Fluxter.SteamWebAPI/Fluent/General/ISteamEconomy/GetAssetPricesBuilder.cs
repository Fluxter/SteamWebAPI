// ------------------------------------------------------------------------------------------------
//  <copyright file="GetAssetPricesBuilder.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Fluent.General.ISteamEconomy
{
    using System;
    using System.ComponentModel;
    using Interfaces.General.ISteamEconomy;
    using Interfaces.General.ISteamEconomy.GetAssetPrices;

    public class
        GetAssetPricesBuilder : SteamBaseBuilder<GetAssetPricesRequest, GetAssetPricesResponse, GetAssetPricesBuilder>
    {
        public GetAssetPricesBuilder(GetAssetPricesRequest request) : base(request)
        {
        }

        /// <summary>
        ///     The ISO 4217 code for currency specific filtering.
        /// </summary>
        /// <see href="http://en.wikipedia.org/wiki/ISO_4217" />
        /// <param name="currency"></param>
        /// <returns></returns>
        public GetAssetPricesBuilder Currency(string currency)
        {
            this.Request.Currency = currency;
            return this;
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