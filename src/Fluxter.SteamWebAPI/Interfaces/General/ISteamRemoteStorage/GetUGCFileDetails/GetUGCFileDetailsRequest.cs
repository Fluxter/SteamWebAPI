// ------------------------------------------------------------------------------------------------
//  <copyright file="GetUGCFileDetailsRequest.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Interfaces.General.ISteamRemoteStorage.GetUGCFileDetails
{
    using Infrastructure;
    using Infrastructure.Objects;

    public class GetUGCFileDetailsRequest : RequestBase
    {
        public GetUGCFileDetailsRequest(string key) : base(key)
        {
        }

        public long SteamID { get; set; }
        public long UGCID { get; set; }
        public int AppID { get; set; }

        protected internal override string EndpointUrl
        {
            get { return "http://api.steampowered.com/ISteamRemoteStorage/GetUGCFileDetails/v1/"; }
        }

        protected override QueryStringDictionary GetParameterList()
        {
            var parameters = base.GetParameterList();
            parameters.Add("ugcid", this.UGCID);
            parameters.Add("appid", this.AppID);

            if (this.SteamID > 0)
            {
                parameters.Add("steamid", this.SteamID);
            }

            return parameters;
        }
    }
}