// ------------------------------------------------------------------------------------------------
//  <copyright file="GetPlayerSummariesRequest.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Interfaces.General.ISteamUser.GetPlayerSummaries
{
    using Infrastructure;
    using Infrastructure.Objects;

    public class GetPlayerSummariesRequest : RequestBase
    {
        public GetPlayerSummariesRequest(string key) : base(key)
        {
        }

        public string SteamIDs { get; set; }

        protected internal override string EndpointUrl
        {
            get { return "http://api.steampowered.com/ISteamUser/GetPlayerSummaries/v0002"; }
        }

        protected override QueryStringDictionary GetParameterList()
        {
            var parameters = base.GetParameterList();
            parameters.Add("steamids", this.SteamIDs);
            return parameters;
        }
    }
}