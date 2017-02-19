namespace PortableSteam.Interfaces.General.ISteamUser
{
    using Newtonsoft.Json;
    using PortableSteam.Infrastructure;
    using PortableSteam.Infrastructure.Converters;
    using System;
    using System.Collections.Generic;

    public class GetFriendListResponse : ResponseBase
    {
        /// <summary>
        /// If the profile is not public or there are no available entries for the given relationship only an empty object will be returned.
        /// </summary>
        [JsonProperty("friendslist")]
        public GetFriendListResponseData Data { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetFriendListResponseData
    {
        /// <summary>
        /// A list of objects for each list entry.
        /// </summary>
        [JsonProperty("friends")]
        public List<Friend> Friends { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class Friend
    {
        /// <summary>
        /// The identity of the friend.
        /// </summary>
        [JsonProperty("steamid")]
        [JsonConverter(typeof(JsonSteamIdentityConverter))]
        public SteamIdentity Identity { get; set; }
        /// <summary>
        /// Role in relation to the given identity.
        /// </summary>
        [JsonProperty("relationship")]
        [JsonConverter(typeof(JsonEnumStringConverter<RelationshipType>))]
        public RelationshipType Relationship { get; set; }
        /// <summary>
        /// A DateTime timestamp of when the friend was added to the list.
        /// </summary>
        [JsonProperty("friend_since")]
        [JsonConverter(typeof(JsonDateTimeConverter))]
        public DateTime FriendSince { get; set; }
    }
}
