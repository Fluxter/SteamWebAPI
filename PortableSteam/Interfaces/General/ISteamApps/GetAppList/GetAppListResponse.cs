namespace PortableSteam.Interfaces.General.ISteamApps
{
    using Newtonsoft.Json;
    using PortableSteam.Infrastructure;
    using System.Collections.Generic;

    public class GetAppListResponse : ResponseBase
    {
        [JsonProperty("applist")]
        public GetAppListResponseData Data { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetAppListResponseData
    {
        /// <summary>
        /// A list of objects containing the title and app ID of each program available in the store.
        /// </summary>
        [JsonProperty("apps")]
        public List<App> Apps { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class App
    {
        /// <summary>
        /// An integer containing the program's ID.
        /// </summary>
        [JsonProperty("appid")]
        public int AppID { get; set; }
        /// <summary>
        /// A string containing the program's publicly facing title.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
