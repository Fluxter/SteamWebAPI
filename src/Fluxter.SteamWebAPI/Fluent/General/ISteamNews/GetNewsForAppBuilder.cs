// ------------------------------------------------------------------------------------------------
//  <copyright file="GetNewsForAppBuilder.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Fluent.General.ISteamNews
{
    using System;
    using System.ComponentModel;
    using Infrastructure;
    using Interfaces.General.ISteamNews;
    using Interfaces.General.ISteamNews.GetNewsForApp;

    public class
        GetNewsForAppBuilder : SteamBaseBuilder<GetNewsForAppRequest, GetNewsForAppResponse, GetNewsForAppBuilder>
    {
        public GetNewsForAppBuilder(GetNewsForAppRequest request) : base(request)
        {
        }

        /// <summary>
        ///     The max length of the contents field.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public GetNewsForAppBuilder MaxLength(int value)
        {
            this.Request.MaxLength = value;
            return this;
        }

        /// <summary>
        ///     Returns posts before this date.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public GetNewsForAppBuilder EndDate(DateTime value)
        {
            this.Request.EndDate = (int) value.ToUnixTimeStamp();
            return this;
        }

        /// <summary>
        ///     The max number of news items to retrieve. Default: 20.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public GetNewsForAppBuilder Count(int value)
        {
            this.Request.Count = value;
            return this;
        }

        /// <summary>
        ///     List of feed names to return news for.
        /// </summary>
        /// <param name="feeds"></param>
        /// <returns></returns>
        public GetNewsForAppBuilder Feeds(params string[] feeds)
        {
            this.Request.Feeds = feeds.ToDelimitedString(",");
            return this;
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override string ToString()
        {
            return base.ToString();
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public new Type GetType()
        {
            return this.GetType();
        }
    }
}