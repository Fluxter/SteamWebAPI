// ------------------------------------------------------------------------------------------------
//  <copyright file="GetCommunityBadgeProgressResponse.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Interfaces.General.IPlayerService.GetCommunityBadgeProgress
{
    using System.Collections.Generic;
    using Infrastructure;
    using Newtonsoft.Json;

    public class GetCommunityBadgeProgressResponse : ResponseBase
    {
        [JsonProperty("response")] public GetCommunityBadgeProgressResponseData Data { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetCommunityBadgeProgressResponseData
    {
        /// <summary>
        ///     Array of quests (actions required to unlock a badge).
        /// </summary>
        [JsonProperty("quests")]
        public List<GetCommunityBadgeProgressResponseQuest> Quests { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetCommunityBadgeProgressResponseQuest
    {
        /// <summary>
        ///     Quest ID; no schema is currently available.
        /// </summary>
        [JsonProperty("questid")]
        public int QuestID { get; set; }

        /// <summary>
        ///     Whether the steam account has completed this quest.
        /// </summary>
        [JsonProperty("completed")]
        public bool Completed { get; set; }
    }
}