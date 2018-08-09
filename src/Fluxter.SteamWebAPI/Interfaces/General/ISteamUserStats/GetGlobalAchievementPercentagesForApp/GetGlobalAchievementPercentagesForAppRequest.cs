// ------------------------------------------------------------------------------------------------
//  <copyright file="GetGlobalAchievementPercentagesForAppRequest.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Interfaces.General.ISteamUserStats.GetGlobalAchievementPercentagesForApp
{
    using Infrastructure;
    using Infrastructure.Objects;

    public class GetGlobalAchievementPercentagesForAppRequest : RequestBase
    {
        public GetGlobalAchievementPercentagesForAppRequest(string key) : base(key)
        {
        }

        public int GameID { get; set; }

        protected internal override string EndpointUrl
        {
            get { return "http://api.steampowered.com/ISteamUserStats/GetGlobalAchievementPercentagesForApp/v0002"; }
        }

        protected override QueryStringDictionary GetParameterList()
        {
            var parameters = base.GetParameterList();
            parameters.Add("gameid", this.GameID);
            return parameters;
        }
    }
}