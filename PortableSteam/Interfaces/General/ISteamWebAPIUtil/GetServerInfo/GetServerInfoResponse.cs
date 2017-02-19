namespace PortableSteam.Interfaces.General.ISteamWebAPIUtil
{
    using Newtonsoft.Json;
    using PortableSteam.Infrastructure;
    using PortableSteam.Infrastructure.Converters;
    using System;

    /// <summary>
    /// Response object for methods relating to the WebAPI itself.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class GetServerInfoResponse : ResponseBase
    {
        /// <summary>
        /// Returns DateTime timestamp of WebAPI server.
        /// </summary>
        [JsonProperty("servertime")]
        [JsonConverter(typeof(JsonDateTimeConverter))]
        public DateTime ServerTime { get; set; }
        /// <summary>
        /// Returns time string of WebAPI server.
        /// </summary>
        [JsonProperty("servertimestring")]
        public string ServerTimeString { get; set; }
    }
}
