namespace PortableSteam.Interfaces.General.ISteamUserStats
{
    using PortableSteam.Infrastructure;
    using PortableSteam.Infrastructure.Objects;
    using System;

    public class GetNumberOfCurrentPlayersRequest : RequestBase
    {
        public GetNumberOfCurrentPlayersRequest(string key) : base(key) { }
        protected internal override string EndpointUrl
        {
            get { return "http://api.steampowered.com/ISteamUserStats/GetNumberOfCurrentPlayers/v1"; }
        }
        public int AppID { get; set; }
        protected override QueryStringDictionary GetParameterList()
        {
            var parameters = base.GetParameterList();
            parameters.Add("appid", AppID);
            return parameters;
        }
    }
}
