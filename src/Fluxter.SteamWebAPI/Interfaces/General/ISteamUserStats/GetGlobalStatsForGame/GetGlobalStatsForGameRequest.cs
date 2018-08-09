// ------------------------------------------------------------------------------------------------
//  <copyright file="GetGlobalStatsForGameRequest.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Interfaces.General.ISteamUserStats.GetGlobalStatsForGame
{
    using Infrastructure;
    using Infrastructure.Objects;

    public class GetGlobalStatsForGameRequest : RequestBase
    {
        public GetGlobalStatsForGameRequest(string key) : base(key)
        {
        }

        public int AppID { get; set; }
        public int Count { get; set; }
        public string[] Names { get; set; }
        public long StartDate { get; set; }
        public long EndDate { get; set; }

        protected internal override string EndpointUrl
        {
            get { return "http://api.steampowered.com/ISteamUserStats/GetGlobalStatsForGame/v0001"; }
        }

        protected override QueryStringDictionary GetParameterList()
        {
            var parameters = base.GetParameterList();
            parameters.Add("appid", this.AppID);
            parameters.Add("count", this.Count);

            if (this.Names != null)
            {
                for (int i = 0; i < this.Names.Length; i++)
                {
                    parameters.Add(string.Format("name[{0}]", i), this.Names[i]);
                }
            }

            if (this.StartDate > 0)
            {
                parameters.Add("startdate", this.StartDate);
            }

            if (this.EndDate > 0)
            {
                parameters.Add("enddate", this.EndDate);
            }

            return parameters;
        }
    }
}