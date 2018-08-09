// ------------------------------------------------------------------------------------------------
//  <copyright file="SteamWebAPIUtilBuilderHandler.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Fluent.General
{
    using System;
    using System.ComponentModel;
    using Interfaces.General.ISteamWebAPIUtil;
    using Interfaces.General.ISteamWebAPIUtil.GetServerInfo;
    using Interfaces.General.ISteamWebAPIUtil.GetSupportedAPIList;
    using ISteamWebAPIUtil;

    public class SteamWebAPIUtilBuilderHandler : SteamBaseBuilderHandler
    {
        public SteamWebAPIUtilBuilderHandler(string key) : base(key)
        {
        }

        /// <summary>
        ///     Returns WebAPI server time and checks server status.
        /// </summary>
        /// <returns></returns>
        public GetServerInfoBuilder GetServerInfo()
        {
            return new GetServerInfoBuilder(new GetServerInfoRequest(this.Key));
        }

        /// <summary>
        ///     Lists all available WebAPI interfaces.
        /// </summary>
        /// <returns></returns>
        public GetSupportedAPIListBuilder GetSupportedAPIList()
        {
            return new GetSupportedAPIListBuilder(new GetSupportedAPIListRequest(this.Key));
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