// ------------------------------------------------------------------------------------------------
//  <copyright file="GetHeroesResponse.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Interfaces.Game.Dota2.IDOTA2.GetHeroes
{
    using System.Collections.Generic;
    using Infrastructure;
    using Newtonsoft.Json;

    public class GetHeroesResponse : ResponseBase
    {
        [JsonProperty("result")] public GetHeroesRequestResponseData Data { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetHeroesRequestResponseData
    {
        /// <summary>
        ///     Number of results.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        ///     List of heroes.
        /// </summary>
        [JsonProperty("heroes")]
        public List<GetHeroesRequestResponseHero> Heroes { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetHeroesRequestResponseHero
    {
        /// <summary>
        ///     The tokenized string for the name of the hero.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        ///     ID of the hero.
        /// </summary>
        [JsonProperty("id")]
        public int ID { get; set; }

        /// <summary>
        ///     The localized name of the hero for use in name display.
        /// </summary>
        [JsonProperty("localized_name")]
        public string LocalizedName { get; set; }
    }
}