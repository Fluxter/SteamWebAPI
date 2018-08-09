// ------------------------------------------------------------------------------------------------
//  <copyright file="GetPlayerBansResponse.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Interfaces.General.ISteamUser.GetPlayerBans
{
    using System.Collections.Generic;
    using Infrastructure;
    using Infrastructure.Converters;
    using Newtonsoft.Json;

    public class GetPlayerBansResponse : ResponseBase
    {
        /// <summary>
        ///     List of player ban objects for each given (and valid) 64 bit ID.
        /// </summary>
        [JsonProperty("players")]
        public List<GetPlayerBansResponsePlayer> Players { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetPlayerBansResponsePlayer
    {
        /// <summary>
        ///     The player's identity.
        /// </summary>
        [JsonProperty("steamid")]
        [JsonConverter(typeof(JsonSteamIdentityConverter))]
        public SteamIdentity Identity { get; set; }

        /// <summary>
        ///     Boolean indicating whether or not the player is banned from
        /// </summary>
        [JsonProperty("communitybanned")]
        public bool CommunityBanned { get; set; }

        /// <summary>
        ///     Boolean indicating whether or not the player has VAC bans on record.
        /// </summary>
        [JsonProperty("vacbanned")]
        public bool VACBanned { get; set; }

        /// <summary>
        ///     String containing the player's ban status in the economy. If the player has no bans on record the string will be
        ///     "none", if the player is on probation it will say "probation", and so forth.
        /// </summary>
        [JsonProperty("economyban")]
        public string EconomyBan { get; set; }
    }
}