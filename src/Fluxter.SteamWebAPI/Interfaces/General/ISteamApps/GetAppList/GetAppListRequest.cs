// ------------------------------------------------------------------------------------------------
//  <copyright file="GetAppListRequest.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Interfaces.General.ISteamApps.GetAppList
{
    using Infrastructure;

    public class GetAppListRequest : RequestBase
    {
        public GetAppListRequest(string key) : base(key)
        {
        }

        protected internal override string EndpointUrl
        {
            get { return "http://api.steampowered.com/ISteamApps/GetAppList/v2"; }
        }
    }
}