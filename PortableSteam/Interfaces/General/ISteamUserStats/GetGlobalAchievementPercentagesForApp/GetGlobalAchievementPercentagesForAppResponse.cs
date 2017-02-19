namespace PortableSteam.Interfaces.General.ISteamUserStats
{
    using Newtonsoft.Json;
    using PortableSteam.Infrastructure;
    using System.Collections.Generic;

    public class GetGlobalAchievementPercentagesForAppResponse : ResponseBase
    {
        [JsonProperty("achievementpercentages")]
        public GetGlobalAchievementPercentagesForAppResponseData Data { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetGlobalAchievementPercentagesForAppResponseData
    {
        [JsonProperty("achievements")]
        public List<GetGlobalAchievementPercentagesForAppResponseAchievement> Achievements { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetGlobalAchievementPercentagesForAppResponseAchievement
    {
        /// <summary>
        /// The name of the achievement as an unlocalized token.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        /// <summary>
        /// Percentage of player population that has unlocked the achievement given as a double.
        /// </summary>
        [JsonProperty("percent")]
        public double Percent { get; set; }
    }
}
