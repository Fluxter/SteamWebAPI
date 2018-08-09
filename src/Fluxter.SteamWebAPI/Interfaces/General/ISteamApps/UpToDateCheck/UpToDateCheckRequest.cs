// ------------------------------------------------------------------------------------------------
//  <copyright file="UpToDateCheckRequest.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Interfaces.General.ISteamApps.UpToDateCheck
{
    using Infrastructure;
    using Infrastructure.Objects;

    public class UpToDateCheckRequest : RequestBase
    {
        public UpToDateCheckRequest(string key) : base(key)
        {
        }

        public int AppID { get; set; }
        public int Version { get; set; }

        protected internal override string EndpointUrl
        {
            get { return "http://api.steampowered.com/ISteamApps/UpToDateCheck/v1"; }
        }

        protected override QueryStringDictionary GetParameterList()
        {
            var parameters = base.GetParameterList();
            parameters.Add("appid", this.AppID);
            parameters.Add("version", this.Version);
            return parameters;
        }
    }
}