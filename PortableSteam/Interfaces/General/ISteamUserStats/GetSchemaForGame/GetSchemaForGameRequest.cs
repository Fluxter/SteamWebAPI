namespace PortableSteam.Interfaces.General.ISteamUserStats
{
    using PortableSteam.Infrastructure;
    using PortableSteam.Infrastructure.Objects;
    using System;

    public class GetSchemaForGameRequest : RequestBase
    {
        public GetSchemaForGameRequest(string key) : base(key) { }
        protected internal override string EndpointUrl
        {
            get { return "http://api.steampowered.com/ISteamUserStats/GetSchemaForGame/v2"; }
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
