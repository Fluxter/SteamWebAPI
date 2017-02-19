namespace PortableSteam.Interfaces.General.ISteamUserStats
{
    using Newtonsoft.Json;
    using PortableSteam.Infrastructure;
    using PortableSteam.Infrastructure.Converters;
    using System.Collections.Generic;

    public class GetPlayerAchievementsResponse : ResponseBase
    {
        [JsonProperty("playerstats")]
        public GetPlayerAchievementsResponseData Data { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetPlayerAchievementsResponseData
    {
        /// <summary>
        /// The identity of the user.
        /// </summary>
        [JsonProperty("steamID")]
        [JsonConverter(typeof(JsonSteamIdentityConverter))]
        public SteamIdentity Identity { get; set; }
        /// <summary>
        /// String containing the game title.
        /// </summary>
        [JsonProperty("gameName")]
        public string GameName { get; set; }
        /// <summary>
        /// Boolean value indicating if the request was successful.
        /// </summary>
        [JsonProperty("success")]
        public bool Success { get; set; }
        /// <summary>
        /// List of achievement objects.
        /// </summary>
        [JsonProperty("achievements")]
        public List<GetPlayerAchievementsResponseAchievement> Achievements { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetPlayerAchievementsResponseAchievement
    {
        /// <summary>
        /// String containing the ID of the achievement.
        /// </summary>
        [JsonProperty("apiname")]
        public string APIName { get; set; }
        /// <summary>
        /// Boolean value indicating whether or not the achievement has been unlocked by the user.
        /// </summary>
        [JsonProperty("achieved")]
        public bool Achieved { get; set; }
        /// <summary>
        /// String containing the localized title of the achievement.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        /// <summary>
        /// String containing the localized string or requirements of the achievement.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
