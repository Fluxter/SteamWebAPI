﻿namespace PortableSteam.Interfaces.General.IPlayerService
{
    using Newtonsoft.Json;
    using PortableSteam.Infrastructure;
    using PortableSteam.Infrastructure.Converters;
    using System;
    using System.Collections.Generic;

    public class GetOwnedGamesResponse : ResponseBase
    {
        [JsonProperty("response")]
        public GetOwnedGamesResponseData Data { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetOwnedGamesResponseData
    {
        /// <summary>
        /// Total number of results.
        /// </summary>
        [JsonProperty("game_count")]
        public int GameCount { get; set; }
        /// <summary>
        /// An array of results.
        /// </summary>
        [JsonProperty("games")]
        public List<GetOwnedGamesResponseGame> Games { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetOwnedGamesResponseGame
    {
        /// <summary>
        /// An integer containing the program's ID.
        /// </summary>
        [JsonProperty("appid")]
        public int AppID { get; set; }
        /// <summary>
        /// A string containing the program's publicly facing title.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        /// <summary>
        /// A TimeSpan of the player's playtime in the past 2 weeks.
        /// </summary>
        [JsonProperty("playtime_2weeks")]
        [JsonConverter(typeof(JsonTimeSpanMinutesConverter))]
        public TimeSpan PlayTime2Weeks { get; set; }
        /// <summary>
        /// A TimeSpan of the the player's total playtime.
        /// </summary>
        [JsonProperty("playtime_forever")]
        [JsonConverter(typeof(JsonTimeSpanMinutesConverter))]
        public TimeSpan PlayTimeTotal { get; set; }
        /// <summary>
        /// The program icon's file name, 
        /// accessible at: http://media.steampowered.com/steamcommunity/public/images/apps/APPID/IMG_ICON_URL.jpg, 
        /// replacing "APPID" and "IMG_ICON_URL" as necessary.
        /// </summary>
        [JsonProperty("img_icon_url")]
        public string IconUrl { get; set; }
        /// <summary>
        /// Whether the program has stats accessible via GetUserStatsForGame and GetGlobalStatsForGame.
        /// </summary>
        [JsonProperty("has_community_visible_stats")]
        public bool HasCommunityVisibleStats { get; set; }
    }
}
