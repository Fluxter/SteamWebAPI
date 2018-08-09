// ------------------------------------------------------------------------------------------------
//  <copyright file="GetNewsForAppResponse.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Interfaces.General.ISteamNews.GetNewsForApp
{
    using System;
    using System.Collections.Generic;
    using Infrastructure;
    using Infrastructure.Converters;
    using Newtonsoft.Json;

    public class GetNewsForAppResponse : ResponseBase
    {
        /// <summary>
        ///     App news.
        /// </summary>
        [JsonProperty("appnews")]
        public GetNewsForAppResponseData Data { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetNewsForAppResponseData
    {
        /// <summary>
        ///     The appid of the item news is fetched for.
        /// </summary>
        [JsonProperty("appid")]
        public int AppID { get; set; }

        /// <summary>
        ///     A list of objects describing each news item.
        /// </summary>
        [JsonProperty("newsitems")]
        public List<NewsItem> NewsItems { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class NewsItem
    {
        /// <summary>
        ///     The unique identifier of the news item.
        /// </summary>
        [JsonProperty("gid")]
        public string GID { get; set; }

        /// <summary>
        ///     Title of the news item.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        ///     Permanent link to the item.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        ///     True if the url given links to an external website. False if it links to the Steam store.
        /// </summary>
        [JsonProperty("is_external_url")]
        public bool IsExternalUrl { get; set; }

        /// <summary>
        ///     The author of the news item.
        /// </summary>
        [JsonProperty("author")]
        public string Author { get; set; }

        /// <summary>
        ///     The article body with a length equal to the given length with an appended ellipsis if it is exceeded.
        /// </summary>
        [JsonProperty("contents")]
        public string Contents { get; set; }

        /// <summary>
        ///     The category label of the news item.
        /// </summary>
        [JsonProperty("feedlabel")]
        public string FeedLabel { get; set; }

        /// <summary>
        ///     A DateTime timestamp of the date the item was posted.
        /// </summary>
        [JsonProperty("date")]
        [JsonConverter(typeof(JsonDateTimeConverter))]
        public DateTime Date { get; set; }

        /// <summary>
        ///     An internal tag that describes the source of the news item.
        /// </summary>
        [JsonProperty("feedname")]
        public string FeedName { get; set; }
    }
}