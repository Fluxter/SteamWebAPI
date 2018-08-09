// ------------------------------------------------------------------------------------------------
//  <copyright file="GetSupportedAPIListResponse.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Interfaces.General.ISteamWebAPIUtil.GetSupportedAPIList
{
    using System.Collections.Generic;
    using Infrastructure;
    using Newtonsoft.Json;

    /// <summary>
    ///     Response object for method that lists all available WebAPI interfaces.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetSupportedAPIListResponse : ResponseBase
    {
        [JsonProperty("apilist")] public GetSupportedAPIListResponseAPIList APIList { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetSupportedAPIListResponseAPIList
    {
        /// <summary>
        ///     Interfaces.
        /// </summary>
        [JsonProperty("interfaces")]
        public List<GetSupportedAPIListResponseInterface> Interfaces { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetSupportedAPIListResponseInterface
    {
        /// <summary>
        ///     Name of Interface.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        ///     Methods with-in the interface.
        /// </summary>
        [JsonProperty("methods")]
        public List<GetSupportedAPIListResponseMethod> Methods { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetSupportedAPIListResponseMethod
    {
        /// <summary>
        ///     Name of method.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        ///     Version of method.
        /// </summary>
        [JsonProperty("version")]
        public int Version { get; set; }

        /// <summary>
        ///     Allowed HTTP method for method (GET, POST).
        /// </summary>
        [JsonProperty("httpmethod")]
        public string HttpMethod { get; set; }

        /// <summary>
        ///     Parameters of the method.
        /// </summary>
        [JsonProperty("parameters")]
        public List<GetSupportedAPIListResponseParameter> Parameters { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetSupportedAPIListResponseParameter
    {
        /// <summary>
        ///     Name of parameter.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        ///     Expected type of value.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        ///     Is input optional for the method.
        /// </summary>
        [JsonProperty("optional")]
        public bool Optional { get; set; }

        /// <summary>
        ///     API Documentation of parameter.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}