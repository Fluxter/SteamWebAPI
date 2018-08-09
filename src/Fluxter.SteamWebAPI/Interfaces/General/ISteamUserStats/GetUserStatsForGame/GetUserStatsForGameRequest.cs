// ------------------------------------------------------------------------------------------------
//  <copyright file="GetUserStatsForGameRequest.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Interfaces.General.ISteamUserStats.GetUserStatsForGame
{
    using Infrastructure;
    using Infrastructure.Objects;

    public class GetUserStatsForGameRequest : RequestBase
    {
        public GetUserStatsForGameRequest(string key) : base(key)
        {
        }

        public int AppID { get; set; }
        public long SteamID { get; set; }

        protected internal override string EndpointUrl
        {
            get { return "http://api.steampowered.com/ISteamUserStats/GetUserStatsForGame/v2"; }
        }

        protected override QueryStringDictionary GetParameterList()
        {
            var parameters = base.GetParameterList();
            parameters.Add("appid", this.AppID);
            parameters.Add("steamid", this.SteamID);
            return parameters;
        }
    }
}