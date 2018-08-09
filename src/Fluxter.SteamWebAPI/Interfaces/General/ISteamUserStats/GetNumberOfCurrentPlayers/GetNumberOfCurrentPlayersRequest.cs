// ------------------------------------------------------------------------------------------------
//  <copyright file="GetNumberOfCurrentPlayersRequest.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Interfaces.General.ISteamUserStats.GetNumberOfCurrentPlayers
{
    using Infrastructure;
    using Infrastructure.Objects;

    public class GetNumberOfCurrentPlayersRequest : RequestBase
    {
        public GetNumberOfCurrentPlayersRequest(string key) : base(key)
        {
        }

        public int AppID { get; set; }

        protected internal override string EndpointUrl
        {
            get { return "http://api.steampowered.com/ISteamUserStats/GetNumberOfCurrentPlayers/v1"; }
        }

        protected override QueryStringDictionary GetParameterList()
        {
            var parameters = base.GetParameterList();
            parameters.Add("appid", this.AppID);
            return parameters;
        }
    }
}