// ------------------------------------------------------------------------------------------------
//  <copyright file="GetBadgesResponse.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Interfaces.General.IPlayerService.GetBadges
{
    using System;
    using System.Collections.Generic;
    using Infrastructure;
    using Infrastructure.Converters;
    using Newtonsoft.Json;

    public class GetBadgesResponse : ResponseBase
    {
        [JsonProperty("response")] public GetBadgesResponseData Data { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetBadgesResponseData
    {
        /// <summary>
        ///     Array of badges.
        /// </summary>
        [JsonProperty("badges")]
        public List<GetBadgesResponseBadge> Badges { get; set; }

        /// <summary>
        ///     Player's current experience points.
        /// </summary>
        [JsonProperty("player_xp")]
        public int PlayerXP { get; set; }

        /// <summary>
        ///     Player's current level.
        /// </summary>
        [JsonProperty("player_level")]
        public int PlayerLevel { get; set; }

        /// <summary>
        ///     Experience points needed to level up,
        /// </summary>
        [JsonProperty("player_xp_needed_to_level_up")]
        public int PlayerXPNeededToLevelUp { get; set; }

        /// <summary>
        ///     Experience points needed for the player's current level.
        /// </summary>
        [JsonProperty("player_xp_needed_current_level")]
        public int PlayerXPNeededCurrentLevel { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetBadgesResponseBadge
    {
        /// <summary>
        ///     Badge ID. Currently no official badge schema is available.
        /// </summary>
        [JsonProperty("badgeid")]
        public int BadgeID { get; set; }

        /// <summary>
        ///     Provided if the badge relates to an app (trading cards).
        /// </summary>
        [JsonProperty("appid")]
        public int AppID { get; set; }

        /// <summary>
        ///     Badge level.
        /// </summary>
        [JsonProperty("level")]
        public int Level { get; set; }

        /// <summary>
        ///     DateTime timestamp of when the steam user acquired the badge.
        /// </summary>
        [JsonProperty("completion_time")]
        [JsonConverter(typeof(JsonDateTimeConverter))]
        public DateTime CompletionTime { get; set; }

        /// <summary>
        ///     The experience this badge is worth, contributing toward the steam account's player experience points.
        /// </summary>
        [JsonProperty("xp")]
        public int XP { get; set; }

        /// <summary>
        ///     Provided if the badge relates to an app (trading cards);
        ///     the value doesn't seem to be an item in the steam accounts backpack,
        ///     however the value minus 1 seems to be the item ID for the emoticon granted for crafting this badge,
        ///     and the value minus 2 seems to be the background granted.
        /// </summary>
        [JsonProperty("communityitemid")]
        public int CommunityItemID { get; set; }

        /// <summary>
        ///     Provided if the badge relates to an app (trading cards).
        /// </summary>
        [JsonProperty("border_color")]
        public string BorderColor { get; set; }

        /// <summary>
        ///     The amount of people who has this badge.
        /// </summary>
        [JsonProperty("scarcity")]
        public long Scarcity { get; set; }
    }
}