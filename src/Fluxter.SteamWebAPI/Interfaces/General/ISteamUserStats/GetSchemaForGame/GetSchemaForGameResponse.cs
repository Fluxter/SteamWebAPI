// ------------------------------------------------------------------------------------------------
//  <copyright file="GetSchemaForGameResponse.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Interfaces.General.ISteamUserStats.GetSchemaForGame
{
    using System.Collections.Generic;
    using Infrastructure;
    using Newtonsoft.Json;

    public class GetSchemaForGameResponse : ResponseBase
    {
        [JsonProperty("game")] public GetSchemaForGameResponseGame Data { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetSchemaForGameResponseGame
    {
        /// <summary>
        ///     Steam internal (non-localized) name of game.
        /// </summary>
        [JsonProperty("gameName")]
        public string GameName { get; set; }

        /// <summary>
        ///     Steam release version number currently live on Steam.
        /// </summary>
        [JsonProperty("gameVersion")]
        public int GameVersion { get; set; }

        /// <summary>
        ///     Available game stats.
        /// </summary>
        [JsonProperty("availableGameStats")]
        public GetSchemaForGameResponseGameStats AvailableGameStats { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetSchemaForGameResponseGameStats
    {
        [JsonProperty("achievements")] public List<GetSchemaForGameResponseAchievements> Achievements { get; set; }

        [JsonProperty("stats")] public List<GetSchemaForGameResponseStats> Stats { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetSchemaForGameResponseAchievements
    {
        /// <summary>
        ///     API Name of achievement.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        ///     Always 0 (player's default state is unachieved).
        /// </summary>
        [JsonProperty("defaultvalue")]
        public int DefaultValue { get; set; }

        /// <summary>
        ///     Display title string of achievement.
        /// </summary>
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        ///     If achievement is hidden to the user before earning achievement, value is true; false if public.
        /// </summary>
        [JsonProperty("hidden")]
        public bool Hidden { get; set; }

        /// <summary>
        ///     Display description string of achievement.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        ///     Absolute URL of earned achievement icon art.
        /// </summary>
        [JsonProperty("icon")]
        public string Icon { get; set; }

        /// <summary>
        ///     Absolute URL of un-earned achievement icon art.
        /// </summary>
        [JsonProperty("icongray")]
        public string IconGray { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetSchemaForGameResponseStats
    {
        /// <summary>
        ///     API name of stat.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        ///     Default value of stat.
        /// </summary>
        [JsonProperty("defaultvalue")]
        public int DefaultValue { get; set; }

        /// <summary>
        ///     Developer provided name of string.
        /// </summary>
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
    }
}