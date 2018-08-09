// ------------------------------------------------------------------------------------------------
//  <copyright file="GetAppListResponse.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Interfaces.General.ISteamApps.GetAppList
{
    using System.Collections.Generic;
    using Infrastructure;
    using Newtonsoft.Json;

    public class GetAppListResponse : ResponseBase
    {
        [JsonProperty("applist")] public GetAppListResponseData Data { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetAppListResponseData
    {
        /// <summary>
        ///     A list of objects containing the title and app ID of each program available in the store.
        /// </summary>
        [JsonProperty("apps")]
        public List<App> Apps { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class App
    {
        /// <summary>
        ///     An integer containing the program's ID.
        /// </summary>
        [JsonProperty("appid")]
        public int AppID { get; set; }

        /// <summary>
        ///     A string containing the program's publicly facing title.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}