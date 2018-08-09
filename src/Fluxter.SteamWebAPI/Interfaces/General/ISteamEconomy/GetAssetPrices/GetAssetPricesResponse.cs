// ------------------------------------------------------------------------------------------------
//  <copyright file="GetAssetPricesResponse.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Interfaces.General.ISteamEconomy.GetAssetPrices
{
    using System.Collections.Generic;
    using Infrastructure;
    using Newtonsoft.Json;

    public class GetAssetPricesResponse : ResponseBase
    {
        /// <summary>
        ///     A list of items with slot tags and prices in the chosen or all currency.
        /// </summary>
        [JsonProperty("assets")]
        public List<Asset> Assets { get; set; }

        /// <summary>
        ///     An array containing friendly names for the tags attached to items.
        /// </summary>
        [JsonProperty("tags")]
        public List<string> Tags { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class Asset
    {
        /// <summary>
        ///     An array containing the currency code and respective price, if a currency is specified only that currency value
        ///     will be present.
        ///     All prices are given as integers due to issues regarding precision. A double value can be obtained by dividing the
        ///     price by 100.
        /// </summary>
        [JsonProperty("prices")]
        public List<int> Prices { get; set; }

        /// <summary>
        ///     An array equivalent to prices in layout. Present when the item is on sale.
        /// </summary>
        [JsonProperty("original_prices")]
        public List<double> OriginalPrices { get; set; }

        /// <summary>
        ///     A list of properties attached to the item.
        /// </summary>
        [JsonProperty("class")]
        public Class Class { get; set; }

        /// <summary>
        ///     The "name" of the asset. This has no set content besides that it is an identifier that can be used in URLs such as
        ///     those for Valve's store frontend.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        ///     The class ID of the item.
        /// </summary>
        [JsonProperty("classid")]
        public int ClassID { get; set; }

        /// <summary>
        ///     An array containing information related to the item's slot or special attributes.
        /// </summary>
        [JsonProperty("tags")]
        public List<string> Tags { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class Class
    {
        /// <summary>
        ///     The name of the property.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        ///     The value of the property.
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}