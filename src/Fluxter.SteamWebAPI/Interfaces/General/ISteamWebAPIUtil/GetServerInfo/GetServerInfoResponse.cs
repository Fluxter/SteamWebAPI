// ------------------------------------------------------------------------------------------------
//  <copyright file="GetServerInfoResponse.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Interfaces.General.ISteamWebAPIUtil.GetServerInfo
{
    using System;
    using Infrastructure;
    using Infrastructure.Converters;
    using Newtonsoft.Json;

    /// <summary>
    ///     Response object for methods relating to the WebAPI itself.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class GetServerInfoResponse : ResponseBase
    {
        /// <summary>
        ///     Returns DateTime timestamp of WebAPI server.
        /// </summary>
        [JsonProperty("servertime")]
        [JsonConverter(typeof(JsonDateTimeConverter))]
        public DateTime ServerTime { get; set; }

        /// <summary>
        ///     Returns time string of WebAPI server.
        /// </summary>
        [JsonProperty("servertimestring")]
        public string ServerTimeString { get; set; }
    }
}