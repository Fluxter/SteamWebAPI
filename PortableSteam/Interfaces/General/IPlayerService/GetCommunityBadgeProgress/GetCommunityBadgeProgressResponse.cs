namespace PortableSteam.Interfaces.General.IPlayerService
{
    using Newtonsoft.Json;
    using PortableSteam.Infrastructure;
    using System.Collections.Generic;

    public class GetCommunityBadgeProgressResponse : ResponseBase
    {
        [JsonProperty("response")]
        public GetCommunityBadgeProgressResponseData Data { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetCommunityBadgeProgressResponseData
    {
        /// <summary>
        /// Array of quests (actions required to unlock a badge).
        /// </summary>
        [JsonProperty("quests")]
        public List<GetCommunityBadgeProgressResponseQuest> Quests { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetCommunityBadgeProgressResponseQuest
    {
        /// <summary>
        /// Quest ID; no schema is currently available.
        /// </summary>
        [JsonProperty("questid")]
        public int QuestID { get; set; }
        /// <summary>
        /// Whether the steam account has completed this quest.
        /// </summary>
        [JsonProperty("completed")]
        public bool Completed { get; set; }
    }
}
