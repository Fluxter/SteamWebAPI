namespace PortableSteam.Infrastructure
{
    using Newtonsoft.Json;
    using System;

    /// <summary>
    /// Base class for steam responses.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class ResponseBase
    {
        /// <summary>
        /// Request URI of this response.
        /// </summary>
        public Uri RequestURI { get; set; }
        /// <summary>
        /// Response for this steam request.
        /// </summary>
        [JsonProperty("response")]
        public Response Response { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class Response
    {
        /// <summary>
        /// True if the query was successful, false otherwise.
        /// </summary>
        [JsonProperty("success")]
        public bool Success { get; set; }
        /// <summary>
        /// Error message of this response.
        /// </summary>
        [JsonProperty("error")]
        public string Error { get; set; }
        /// <summary>
        /// Error code of this response.
        /// </summary>
        [JsonProperty("errorCode")]
        public int ErrorCode { get; set; }
    }
}
