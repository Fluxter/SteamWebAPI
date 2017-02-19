namespace PortableSteam.Interfaces.General.ISteamUser
{
    using Newtonsoft.Json;
    using PortableSteam.Infrastructure;
    using PortableSteam.Infrastructure.Converters;
    using System;
    using System.Collections.Generic;

    public class GetUserGroupListResponse : ResponseBase
    {
        [JsonProperty("response")]
        public GetUserGroupListResponse Data { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetUserGroupListResponseResponse
    {
        /// <summary>
        /// True if the query was successful, false otherwise.
        /// </summary>
        [JsonProperty("success")]
        public bool Success { get; set; }
        /// <summary>
        /// Error message of this response.
        /// </summary>
        [JsonProperty("error")]
        public string Error { get; set; }
        /// <summary>
        /// If the profile is not public or there are no available entries for the given relationship only an empty object will be returned.
        /// </summary>
        [JsonProperty("groups")]
        public List<GetUserGroupListResponseGroup> Groups { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetUserGroupListResponseGroup
    {
        /// <summary>
        /// 64 bit ID number of group.
        /// </summary>
        [JsonProperty("gid")]
        public long GID{ get; set; }
    }
}
