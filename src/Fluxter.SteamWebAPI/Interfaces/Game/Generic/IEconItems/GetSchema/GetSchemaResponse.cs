// ------------------------------------------------------------------------------------------------
//  <copyright file="GetSchemaResponse.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Interfaces.Game.Generic.IEconItems.GetSchema
{
    using System.Collections.Generic;
    using Infrastructure;
    using Newtonsoft.Json;

    /// <summary>
    ///     TODO.
    /// </summary>
    public class GetSchemaResponse : ResponseBase
    {
        [JsonProperty("result")] public GetSchemaResponseData Data { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetSchemaResponseData
    {
        /// <summary>
        ///     The status of the request, should always be 1.
        /// </summary>
        [JsonProperty("status")]
        public int Status { get; set; }

        /// <summary>
        ///     A string containing the URL to the full item schema as used by the game.
        /// </summary>
        [JsonProperty("items_game_url")]
        public string ItemsGameUrl { get; set; }

        /// <summary>
        ///     A list of item objects.
        /// </summary>
        [JsonProperty("items")]
        public List<GetSchemaResponseItem> Items { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetSchemaResponseItem
    {
    }
}