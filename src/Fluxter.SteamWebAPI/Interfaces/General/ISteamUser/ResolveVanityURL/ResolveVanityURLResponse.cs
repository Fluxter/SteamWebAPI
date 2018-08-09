// ------------------------------------------------------------------------------------------------
//  <copyright file="ResolveVanityURLResponse.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Interfaces.General.ISteamUser.ResolveVanityURL
{
    using Infrastructure;
    using Infrastructure.Converters;
    using Newtonsoft.Json;

    public class ResolveVanityURLResponse : ResponseBase
    {
        /// <summary>
        ///     If the profile is not public or there are no available entries for the given relationship only an empty object will
        ///     be returned.
        /// </summary>
        [JsonProperty("response")]
        public ResolveVanityURLResponseResponse Data { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class ResolveVanityURLResponseResponse
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
        ///     The identity the vanity URL resolves to. Not returned on resolution failures.
        /// </summary>
        [JsonProperty("steamid")]
        [JsonConverter(typeof(JsonSteamIdentityConverter))]
        public SteamIdentity Identity { get; set; }
    }
}