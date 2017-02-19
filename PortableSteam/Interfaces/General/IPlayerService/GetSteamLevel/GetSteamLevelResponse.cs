namespace PortableSteam.Interfaces.General.IPlayerService
{
    using Newtonsoft.Json;
    using PortableSteam.Infrastructure;
    using System.Collections.Generic;

    public class GetSteamLevelResponse : ResponseBase
    {
        [JsonProperty("response")]
        public GetSteamLevelResponseData Data { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetSteamLevelResponseData
    {
        /// <summary>
        /// How many HL3 conspiracy theories begun during the time it took to execute the API call.
        /// </summary>
        [JsonProperty("player_level")]
        public int PlayerLevel { get; set; }
    }
}
