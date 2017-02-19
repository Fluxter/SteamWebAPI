namespace PortableSteam.Interfaces.General.ISteamUserStats
{
    using PortableSteam.Infrastructure;
    using PortableSteam.Infrastructure.Objects;
    using System;

    public class GetPlayerAchievementsRequest : RequestBase
    {
        public GetPlayerAchievementsRequest(string key) : base(key) { }
        protected internal override string EndpointUrl
        {
            get { return "http://api.steampowered.com/ISteamUserStats/GetPlayerAchievements/v1"; }
        }
        public int AppID { get; set; }
        public long SteamID { get; set; }
        protected override QueryStringDictionary GetParameterList()
        {
            var parameters = base.GetParameterList();
            parameters.Add("appid", AppID);
            parameters.Add("steamid", SteamID);
            return parameters;
        }
    }
}
