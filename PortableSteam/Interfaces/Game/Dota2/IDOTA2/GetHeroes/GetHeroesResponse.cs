namespace PortableSteam.Interfaces.Game.Dota2.IDOTA2
{
    using Newtonsoft.Json;
    using PortableSteam.Infrastructure;
    using PortableSteam.Infrastructure.Converters;
    using System.Collections.Generic;

    public class GetHeroesResponse : ResponseBase
    {
        [JsonProperty("result")]
        public GetHeroesRequestResponseData Data { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetHeroesRequestResponseData
    {
        /// <summary>
        /// Number of results.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        /// <summary>
        /// List of heroes.
        /// </summary>
        [JsonProperty("heroes")]
        public List<GetHeroesRequestResponseHero> Heroes { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetHeroesRequestResponseHero
    {
        /// <summary>
        /// The tokenized string for the name of the hero.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        /// <summary>
        /// ID of the hero.
        /// </summary>
        [JsonProperty("id")]
        public int ID { get; set; }
        /// <summary>
        /// The localized name of the hero for use in name display.
        /// </summary>
        [JsonProperty("localized_name")]
        public string LocalizedName { get; set; }
    }
}
