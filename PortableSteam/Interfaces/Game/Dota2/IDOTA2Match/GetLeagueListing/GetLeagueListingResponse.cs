namespace PortableSteam.Interfaces.Game.Dota2.IDOTA2
{
    using Newtonsoft.Json;
    using PortableSteam.Infrastructure;
    using PortableSteam.Infrastructure.Converters;
    using System.Collections.Generic;

    public class GetLeagueListingResponse : ResponseBase
    {
        [JsonProperty("result")]
        public GetLeagueListingResponseData Data { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetLeagueListingResponseData
    {
        /// <summary>
        /// A list of leagues supported in-game via DotaTV.
        /// </summary>
        [JsonProperty("leagues")]
        public List<GetLeagueListingResponseLeague> Leagues { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetLeagueListingResponseLeague
    {
        /// <summary>
        /// The name of the league.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        /// <summary>
        /// The league's unique ID.
        /// </summary>
        [JsonProperty("league_id")]
        public long LeagueID { get; set; }
        /// <summary>
        /// A description of the league.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
        /// <summary>
        /// The league's website.
        /// </summary>
        [JsonProperty("tournament_url")]
        public string TournamentUrl { get; set; }
    }
}
