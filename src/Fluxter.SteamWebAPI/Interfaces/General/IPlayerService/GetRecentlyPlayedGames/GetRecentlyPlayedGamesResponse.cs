// ------------------------------------------------------------------------------------------------
//  <copyright file="GetRecentlyPlayedGamesResponse.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Interfaces.General.IPlayerService.GetRecentlyPlayedGames
{
    using System;
    using System.Collections.Generic;
    using Infrastructure;
    using Infrastructure.Converters;
    using Newtonsoft.Json;

    public class GetRecentlyPlayedGamesResponse : ResponseBase
    {
        [JsonProperty("response")] public GetRecentlyPlayedGamesResponseData Data { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetRecentlyPlayedGamesResponseData
    {
        /// <summary>
        ///     Total number of results.
        /// </summary>
        [JsonProperty("total_count")]
        public int TotalCount { get; set; }

        /// <summary>
        ///     An array of results.
        /// </summary>
        [JsonProperty("games")]
        public List<GetRecentlyPlayedGamesResponseGame> Games { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetRecentlyPlayedGamesResponseGame
    {
        /// <summary>
        ///     An integer containing the program's ID.
        /// </summary>
        [JsonProperty("appid")]
        public int AppID { get; set; }

        /// <summary>
        ///     A string containing the program's publicly facing title.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        ///     A TimeSpan of the player's playtime in the past 2 weeks.
        /// </summary>
        [JsonProperty("playtime_2weeks")]
        [JsonConverter(typeof(JsonTimeSpanMinutesConverter))]
        public TimeSpan PlayTime2Weeks { get; set; }

        /// <summary>
        ///     A TimeSpan of the the player's total playtime.
        /// </summary>
        [JsonProperty("playtime_forever")]
        [JsonConverter(typeof(JsonTimeSpanMinutesConverter))]
        public TimeSpan PlayTimeTotal { get; set; }

        /// <summary>
        ///     The program icon's file name,
        ///     accessible at: http://media.steampowered.com/steamcommunity/public/images/apps/APPID/IMG_ICON_URL.jpg,
        ///     replacing "APPID" and "IMG_ICON_URL" as necessary.
        /// </summary>
        [JsonProperty("img_icon_url")]
        public string IconUrl { get; set; }
    }
}