namespace PortableSteam.Interfaces.General.ISteamUserStats
{
    using Newtonsoft.Json;
    using PortableSteam.Infrastructure;
    using System.Collections.Generic;

    /// <summary>
    /// TODO
    /// </summary>
    public class GetGlobalStatsForGameResponse : ResponseBase
    {
        [JsonProperty("response")]
        public GetGlobalStatsForGameResponseData Data { get; set; }
        /// <summary>
        /// Returns result code.
        /// </summary>
        [JsonProperty("result")]
        public int Result { get; set; }
        /// <summary>
        /// Returns error.
        /// </summary>
        [JsonProperty("error")]
        public string Error { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetGlobalStatsForGameResponseData
    {
        /// <summary>
        /// An array of results.
        /// </summary>
        [JsonProperty("globalstats")]
        public List<GetGlobalStatsForGameResponseStat> Stats { get; set; }
    }

    
    public sealed class GetGlobalStatsForGameResponseStat
    {
        /// <summary>
        /// The name of the requested stat.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The value of the stat.
        /// </summary>
        public string Value { get; set; }
    }
}
