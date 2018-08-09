// ------------------------------------------------------------------------------------------------
//  <copyright file="GetSchemaURLResponse.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Interfaces.Game.Generic.IEconItems.GetSchemaURL
{
    using Infrastructure;
    using Newtonsoft.Json;

    public class GetSchemaURLResponse : ResponseBase
    {
        [JsonProperty("result")] public GetSchemaURLResponseData Data { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetSchemaURLResponseData
    {
        /// <summary>
        ///     The status of the request, should always be 1.
        /// </summary>
        [JsonProperty("status")]
        public int Status { get; set; }

        /// <summary>
        ///     URL of the items_game.txt file.
        /// </summary>
        [JsonProperty("items_game_url")]
        public string ItemsGameUrl { get; set; }
    }
}