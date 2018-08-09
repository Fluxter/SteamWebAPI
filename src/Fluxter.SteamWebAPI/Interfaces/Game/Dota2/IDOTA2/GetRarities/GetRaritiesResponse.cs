// ------------------------------------------------------------------------------------------------
//  <copyright file="GetRaritiesResponse.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Interfaces.Game.Dota2.IDOTA2.GetRarities
{
    using System.Collections.Generic;
    using Infrastructure;
    using Newtonsoft.Json;

    public class GetRaritiesResponse : ResponseBase
    {
        [JsonProperty("result")] public GetRaritiesRequestResponseData Data { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetRaritiesRequestResponseData
    {
        /// <summary>
        ///     Possible number of rarities. This number appears to be currently incorrect and off by one.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        ///     List of rarity objects.
        /// </summary>
        [JsonProperty("rarities")]
        public List<GetRaritiesRequestResponseRarity> Rarities { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetRaritiesRequestResponseRarity
    {
        /// <summary>
        ///     The internal rarity name string.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        ///     ID of rarity, used for indexing.
        /// </summary>
        [JsonProperty("id")]
        public int ID { get; set; }

        /// <summary>
        ///     Sorting and logical order of rarities, from most distributed to least.
        /// </summary>
        [JsonProperty("order")]
        public int Order { get; set; }

        /// <summary>
        ///     String of the hexadecimal RGB tuple of the rarity name as it is displayed in-game.
        /// </summary>
        [JsonProperty("color")]
        public string Color { get; set; }

        /// <summary>
        ///     The localized name of the rarity for use in name display.
        /// </summary>
        [JsonProperty("localized_name")]
        public string LocalizedName { get; set; }
    }
}