// ------------------------------------------------------------------------------------------------
//  <copyright file="ResponseBase.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Infrastructure
{
    using System;
    using Newtonsoft.Json;

    /// <summary>
    ///     Base class for steam responses.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class ResponseBase
    {
        /// <summary>
        ///     Request URI of this response.
        /// </summary>
        public Uri RequestURI { get; set; }

        /// <summary>
        ///     Response for this steam request.
        /// </summary>
        [JsonProperty("response")]
        public Response Response { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class Response
    {
        /// <summary>
        ///     True if the query was successful, false otherwise.
        /// </summary>
        [JsonProperty("success")]
        public bool Success { get; set; }

        /// <summary>
        ///     Error message of this response.
        /// </summary>
        [JsonProperty("error")]
        public string Error { get; set; }

        /// <summary>
        ///     Error code of this response.
        /// </summary>
        [JsonProperty("errorCode")]
        public int ErrorCode { get; set; }
    }
}