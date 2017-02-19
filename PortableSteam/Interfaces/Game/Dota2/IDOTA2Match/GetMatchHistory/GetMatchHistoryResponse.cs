namespace PortableSteam.Interfaces.Game.Dota2.IDOTA2
{
    using Newtonsoft.Json;
    using PortableSteam.Infrastructure;
    using PortableSteam.Infrastructure.Converters;
    using System;
    using System.Collections.Generic;

    public class GetMatchHistoryResponse : ResponseBase
    {
        [JsonProperty("result")]
        public GetMatchHistoryResponseData Data { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetMatchHistoryResponseData
    {
        /// <summary>
        /// Query status.
        /// </summary>
        [JsonProperty("status")]
        [JsonConverter(typeof(JsonEnumConverter<GetMatchHistoryResponseStatus>))]
        public GetMatchHistoryResponseStatus Status { get; set; }
        /// <summary>
        /// A message explaining the status, should status not be 1.
        /// </summary>
        [JsonProperty("statusdetail")]
        public string StatusDetail { get; set; }
        /// <summary>
        /// The number of matches in this response.
        /// </summary>
        [JsonProperty("num_results")]
        public int NumberOfResults { get; set; }
        /// <summary>
        /// The total number of matches for the query.
        /// </summary>
        [JsonProperty("total_results")]
        public int TotalResults { get; set; }
        /// <summary>
        /// The number of matches left for this query.
        /// </summary>
        [JsonProperty("results_remaining")]
        public int ResultsRemaining { get; set; }
        /// <summary>
        /// A list of matches.
        /// </summary>
        [JsonProperty("matches")]
        public List<GetMatchHistoryResponseMatch> Matches { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetMatchHistoryResponseMatch
    {
        /// <summary>
        /// The matches unique ID.
        /// </summary>
        [JsonProperty("match_id")]
        public long MatchID { get; set; }
        /// <summary>
        /// A 'sequence number', representing the order in which matches were recorded.
        /// </summary>
        [JsonProperty("match_seq_num")]
        public long MatchSequenceNumber { get; set; }
        /// <summary>
        /// DateTime timestamp of when the match began.
        /// </summary>
        [JsonProperty("start_time")]
        [JsonConverter(typeof(JsonDateTimeConverter))]
        public DateTime StartTime { get; set; }
        /// <summary>
        /// Lobby type.
        /// </summary>
        [JsonProperty("lobby_type")]
        [JsonConverter(typeof(JsonEnumConverter<Dota2LobbyType>))]
        public Dota2LobbyType LobbyType { get; set; }
        /// <summary>
        /// List of players in the match.
        /// </summary>
        [JsonProperty("players")]
        public List<GetMatchHistoryResponsePlayer> Players { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetMatchHistoryResponsePlayer
    {
        /// <summary>
        /// 32-bit account ID.
        /// </summary>
        [JsonProperty("account_id")]
        [JsonConverter(typeof(JsonSteamIdentityAccountConverter))]
        public SteamIdentity Identity { get; set; }
        /// <summary>
        /// http://wiki.teamfortress.com/wiki/WebAPI/GetMatchDetails#Player_Slot
        /// </summary>
        [JsonProperty("player_slot")]
        public long PlayerSlot { get; set; }
        /// <summary>
        /// The hero's unique ID. A list of hero IDs can be found via the GetHeroes method.
        /// </summary>
        [JsonProperty("hero_id")]
        public int HeroID { get; set; }
    }
}
