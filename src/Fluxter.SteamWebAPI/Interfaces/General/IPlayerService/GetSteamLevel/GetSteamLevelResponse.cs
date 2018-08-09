// ------------------------------------------------------------------------------------------------
//  <copyright file="GetSteamLevelResponse.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Interfaces.General.IPlayerService.GetSteamLevel
{
    using Infrastructure;
    using Newtonsoft.Json;

    public class GetSteamLevelResponse : ResponseBase
    {
        [JsonProperty("response")] public GetSteamLevelResponseData Data { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetSteamLevelResponseData
    {
        /// <summary>
        ///     How many HL3 conspiracy theories begun during the time it took to execute the API call.
        /// </summary>
        [JsonProperty("player_level")]
        public int PlayerLevel { get; set; }
    }
}