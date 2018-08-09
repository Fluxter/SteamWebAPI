// ------------------------------------------------------------------------------------------------
//  <copyright file="GetNumberOfCurrentPlayersResponse.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Interfaces.General.ISteamUserStats.GetNumberOfCurrentPlayers
{
    using Infrastructure;
    using Newtonsoft.Json;

    public class GetNumberOfCurrentPlayersResponse : ResponseBase
    {
        [JsonProperty("response")] public GetNumberOfCurrentPlayersResponseResponse Data { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetNumberOfCurrentPlayersResponseResponse
    {
        /// <summary>
        ///     The status of the request. 1 if successful, 42 if there was no match.
        /// </summary>
        [JsonProperty("success")]
        public int Success { get; set; }

        /// <summary>
        ///     The message associated with the request status. Currently only used on resolution failures.
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <summary>
        ///     Player count.
        /// </summary>
        [JsonProperty("player_count")]
        public int PlayerCount { get; set; }
    }
}