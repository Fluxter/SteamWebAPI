// ------------------------------------------------------------------------------------------------
//  <copyright file="GetServerInfoRequest.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Interfaces.General.ISteamWebAPIUtil.GetServerInfo
{
    using Infrastructure;

    /// <summary>
    ///     Request object for methods relating to the WebAPI itself.
    /// </summary>
    public class GetServerInfoRequest : RequestBase
    {
        public GetServerInfoRequest(string key) : base(key)
        {
        }

        protected internal override string EndpointUrl
        {
            get { return "http://api.steampowered.com/ISteamWebAPIUtil/GetServerInfo/v0001/"; }
        }
    }
}