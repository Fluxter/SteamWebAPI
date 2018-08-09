// ------------------------------------------------------------------------------------------------
//  <copyright file="UpToDateCheckResponse.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Interfaces.General.ISteamApps.UpToDateCheck
{
    using Infrastructure;
    using Newtonsoft.Json;

    public class UpToDateCheckResponse : ResponseBase
    {
        /// <summary>
        ///     Boolean indicating if the given version number is the most current version.
        /// </summary>
        [JsonProperty("up_to_date")]
        public bool UpToDate { get; set; }

        /// <summary>
        ///     Boolean indicating if the given version can be listed in public changelogs.
        /// </summary>
        [JsonProperty("version_is_listable")]
        public bool VersionIsListable { get; set; }

        /// <summary>
        ///     Integer of the most current version of the app available.
        /// </summary>
        [JsonProperty("required_version ")]
        public int? RequiredVersion { get; set; }

        /// <summary>
        ///     A string giving the status message if applicable.
        /// </summary>
        [JsonProperty("message ")]
        public string Message { get; set; }
    }
}