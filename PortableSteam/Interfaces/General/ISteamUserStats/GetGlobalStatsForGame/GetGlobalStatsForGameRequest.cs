namespace PortableSteam.Interfaces.General.ISteamUserStats
{
    using PortableSteam.Infrastructure;
    using PortableSteam.Infrastructure.Objects;
    using System;

    public class GetGlobalStatsForGameRequest : RequestBase
    {
        public GetGlobalStatsForGameRequest(string key) : base(key) { }
        protected internal override string EndpointUrl
        {
            get { return "http://api.steampowered.com/ISteamUserStats/GetGlobalStatsForGame/v0001"; }
        }
        public int AppID { get; set; }
        public int Count { get; set; }
        public string[] Names { get; set; }
        public long StartDate { get; set; }
        public long EndDate { get; set; }
        protected override QueryStringDictionary GetParameterList()
        {
            var parameters = base.GetParameterList();
            parameters.Add("appid", AppID);
            parameters.Add("count", Count);

            if (Names != null)
            {
                for (int i = 0; i < Names.Length; i++)
                {
                    parameters.Add(string.Format("name[{0}]", i), Names[i]);
                }
            }
            if (StartDate > 0)
            {
                parameters.Add("startdate", StartDate);
            }

            if (EndDate > 0)
            {
                parameters.Add("enddate", EndDate);
            }

            return parameters;
        }
    }
}
