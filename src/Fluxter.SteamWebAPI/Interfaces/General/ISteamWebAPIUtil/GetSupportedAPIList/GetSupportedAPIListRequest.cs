// ------------------------------------------------------------------------------------------------
//  <copyright file="GetSupportedAPIListRequest.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Interfaces.General.ISteamWebAPIUtil.GetSupportedAPIList
{
    using Infrastructure;

    /// <summary>
    ///     Request object for method that lists all available WebAPI interfaces.
    /// </summary>
    public class GetSupportedAPIListRequest : RequestBase
    {
        public GetSupportedAPIListRequest(string key) : base(key)
        {
        }

        protected internal override string EndpointUrl
        {
            get { return "http://api.steampowered.com/ISteamWebAPIUtil/GetSupportedAPIList/v0001/"; }
        }
    }
}