namespace PortableSteam.Interfaces.General.ISteamApps
{
    using Newtonsoft.Json;
    using PortableSteam.Infrastructure;

    public class UpToDateCheckResponse : ResponseBase
    {
        /// <summary>
        /// Boolean indicating if the given version number is the most current version.
        /// </summary>
        [JsonProperty("up_to_date")]
        public bool UpToDate { get; set; }
        /// <summary>
        /// Boolean indicating if the given version can be listed in public changelogs.
        /// </summary>
        [JsonProperty("version_is_listable")]
        public bool VersionIsListable { get; set; }
        /// <summary>
        /// Integer of the most current version of the app available.
        /// </summary>
        [JsonProperty("required_version ")]
        public int? RequiredVersion { get; set; }
        /// <summary>
        /// A string giving the status message if applicable.
        /// </summary>
        [JsonProperty("message ")]
        public string Message { get; set; }
    }
}
