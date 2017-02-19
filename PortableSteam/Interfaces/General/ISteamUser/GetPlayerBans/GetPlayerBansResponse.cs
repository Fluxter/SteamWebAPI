namespace PortableSteam.Interfaces.General.ISteamUser
{
    using Newtonsoft.Json;
    using PortableSteam.Infrastructure;
    using PortableSteam.Infrastructure.Converters;
    using System;
    using System.Collections.Generic;

    public class GetPlayerBansResponse : ResponseBase
    {
        /// <summary>
        /// List of player ban objects for each given (and valid) 64 bit ID.
        /// </summary>
        [JsonProperty("players")]
        public List<GetPlayerBansResponsePlayer> Players { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetPlayerBansResponsePlayer
    {
        /// <summary>
        /// The player's identity.
        /// </summary>
        [JsonProperty("steamid")]
        [JsonConverter(typeof(JsonSteamIdentityConverter))]
        public SteamIdentity Identity { get; set; }
        /// <summary>
        /// Boolean indicating whether or not the player is banned from
        /// </summary>
        [JsonProperty("communitybanned")]
        public bool CommunityBanned { get; set; }
        /// <summary>
        /// Boolean indicating whether or not the player has VAC bans on record.
        /// </summary>
        [JsonProperty("vacbanned")]
        public bool VACBanned { get; set; }
        /// <summary>
        /// String containing the player's ban status in the economy. If the player has no bans on record the string will be "none", if the player is on probation it will say "probation", and so forth.
        /// </summary>
        [JsonProperty("economyban")]
        public string EconomyBan { get; set; }
    }
}
