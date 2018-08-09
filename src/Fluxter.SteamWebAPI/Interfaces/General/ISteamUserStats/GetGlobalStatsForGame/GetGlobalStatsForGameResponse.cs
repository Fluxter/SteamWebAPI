// ------------------------------------------------------------------------------------------------
//  <copyright file="GetGlobalStatsForGameResponse.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Interfaces.General.ISteamUserStats.GetGlobalStatsForGame
{
    using System.Collections.Generic;
    using Infrastructure;
    using Newtonsoft.Json;

    /// <summary>
    ///     TODO
    /// </summary>
    public class GetGlobalStatsForGameResponse : ResponseBase
    {
        [JsonProperty("response")] public GetGlobalStatsForGameResponseData Data { get; set; }

        /// <summary>
        ///     Returns result code.
        /// </summary>
        [JsonProperty("result")]
        public int Result { get; set; }

        /// <summary>
        ///     Returns error.
        /// </summary>
        [JsonProperty("error")]
        public string Error { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetGlobalStatsForGameResponseData
    {
        /// <summary>
        ///     An array of results.
        /// </summary>
        [JsonProperty("globalstats")]
        public List<GetGlobalStatsForGameResponseStat> Stats { get; set; }
    }


    public sealed class GetGlobalStatsForGameResponseStat
    {
        /// <summary>
        ///     The name of the requested stat.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     The value of the stat.
        /// </summary>
        public string Value { get; set; }
    }
}