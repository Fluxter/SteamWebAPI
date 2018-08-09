// ------------------------------------------------------------------------------------------------
//  <copyright file="GetUserStatsForGameResponse.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Interfaces.General.ISteamUserStats.GetUserStatsForGame
{
    using System.Collections.Generic;
    using Infrastructure;
    using Infrastructure.Converters;
    using Newtonsoft.Json;

    public class GetUserStatsForGameResponse : ResponseBase
    {
        [JsonProperty("playerstats")] public GetUserStatsForGameResponseData Data { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetUserStatsForGameResponseData
    {
        /// <summary>
        ///     Steam internal (non-localized) name of game.
        /// </summary>
        [JsonProperty("gameName")]
        public string GameName { get; set; }

        /// <summary>
        ///     The Identity of the user.
        /// </summary>
        [JsonProperty("steamID")]
        [JsonConverter(typeof(JsonSteamIdentityConverter))]
        public SteamIdentity Identity { get; set; }

        /// <summary>
        ///     List of achievement objects.
        /// </summary>
        [JsonProperty("achievements")]
        public List<GetUserStatsForGameResponseAchievements> Achievements { get; set; }

        /// <summary>
        ///     List of stats.
        /// </summary>
        [JsonProperty("stats")]
        public List<GetUserStatsForGameResponseStats> Stats { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetUserStatsForGameResponseAchievements
    {
        /// <summary>
        ///     API Name of achievement.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        ///     Boolean value indicating whether or not the achievement has been unlocked by the user.
        /// </summary>
        [JsonProperty("achieved")]
        public bool Achieved { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetUserStatsForGameResponseStats
    {
        /// <summary>
        ///     API name of stat.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        ///     Default value of stat.
        /// </summary>
        [JsonProperty("value")]
        public int Value { get; set; }
    }
}