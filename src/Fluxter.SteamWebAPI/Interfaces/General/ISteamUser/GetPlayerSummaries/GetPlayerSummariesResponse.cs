// ------------------------------------------------------------------------------------------------
//  <copyright file="GetPlayerSummariesResponse.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Interfaces.General.ISteamUser.GetPlayerSummaries
{
    using System;
    using System.Collections.Generic;
    using Types;
    using Infrastructure;
    using Infrastructure.Converters;
    using Newtonsoft.Json;
    using Types;

    public class GetPlayerSummariesResponse : ResponseBase
    {
        [JsonProperty("response")] public GetPlayerSummariesResponseData Data { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetPlayerSummariesResponseData
    {
        /// <summary>
        ///     List of player ban objects for each given (and valid) 64 bit ID.
        /// </summary>
        [JsonProperty("players")]
        public List<GetPlayerSummariesResponsePlayer> Players { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetPlayerSummariesResponsePlayer
    {
        /// <summary>
        ///     The player's identity.
        /// </summary>
        [JsonProperty("steamid")]
        [JsonConverter(typeof(JsonSteamIdentityConverter))]
        public SteamIdentity Identity { get; set; }

        /// <summary>
        ///     An enum that describes the access setting of the profile
        /// </summary>
        [JsonProperty("communityvisibilitystate")]
        [JsonConverter(typeof(JsonEnumConverter<CommunityVisibilityState>))]
        public CommunityVisibilityState CommunityVisibilityState { get; set; }

        /// <summary>
        ///     If set to 1 the user has configured the profile.
        /// </summary>
        [JsonProperty("profilestate")]
        public int ProfileState { get; set; }

        /// <summary>
        ///     User's display name.
        /// </summary>
        [JsonProperty("personaname")]
        public string PersonaName { get; set; }

        /// <summary>
        ///     A DateTime timestamp of when the user was last online.
        /// </summary>
        [JsonProperty("lastlogoff")]
        [JsonConverter(typeof(JsonDateTimeConverter))]
        public DateTime LastLogOff { get; set; }

        /// <summary>
        ///     The URL to the user's Steam Community profile.
        /// </summary>
        [JsonProperty("profileurl")]
        public string ProfileUrl { get; set; }

        /// <summary>
        ///     A 32x32 image url.
        /// </summary>
        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        /// <summary>
        ///     A 64x64 image url.
        /// </summary>
        [JsonProperty("avatarmedium")]
        public string AvatarMedium { get; set; }

        /// <summary>
        ///     A 184x184 image url.
        /// </summary>
        [JsonProperty("avatarfull")]
        public string AvatarFull { get; set; }

        /// <summary>
        ///     The user's status.
        /// </summary>
        [JsonProperty("personastate")]
        [JsonConverter(typeof(JsonEnumConverter<PersonaState>))]
        public PersonaState PersonaState { get; set; }

        /// <summary>
        ///     If not null the profile allows public comments.
        /// </summary>
        [JsonProperty("commentpermission ")]
        public bool? CommentPermission { get; set; }

        /// <summary>
        ///     The user's real name.
        /// </summary>
        [JsonProperty("realname")]
        public string RealName { get; set; }

        /// <summary>
        ///     The 64 bit ID of the user's primary group.
        /// </summary>
        [JsonProperty("primaryclanid")]
        public long? PrimaryClanID { get; set; }

        /// <summary>
        ///     A DateTime timestamp of the date the profile was created.
        /// </summary>
        [JsonProperty("timecreated")]
        [JsonConverter(typeof(JsonDateTimeConverter))]
        public DateTime? TimeCreated { get; set; }

        /// <summary>
        ///     ISO 3166 code of where the user is located.
        /// </summary>
        [JsonProperty("loccountrycode")]
        public string LocCountryCode { get; set; }

        /// <summary>
        ///     Variable length code representing the state the user is located in.
        /// </summary>
        [JsonProperty("locstatecode")]
        public string LocStateCode { get; set; }

        /// <summary>
        ///     An integer ID internal to Steam representing the user's city.
        /// </summary>
        [JsonProperty("loccityid")]
        public int? LocCityID { get; set; }

        /// <summary>
        ///     If the user is in game this will be set to it's app ID as a string.
        /// </summary>
        [JsonProperty("gameid")]
        public string GameID { get; set; }

        /// <summary>
        ///     The title of the game.
        /// </summary>
        [JsonProperty("gameextrainfo")]
        public string GameExtraInfo { get; set; }

        /// <summary>
        ///     The server URL given as an IP address and port number separated by a colon, this will not be present or set to
        ///     "0.0.0.0:0" if none is available.
        /// </summary>
        [JsonProperty("gameserverip")]
        public string GameServerIP { get; set; }
    }
}