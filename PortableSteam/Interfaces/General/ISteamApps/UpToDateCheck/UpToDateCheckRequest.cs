namespace PortableSteam.Interfaces.General.ISteamApps
{
    using PortableSteam.Infrastructure;
    using System;

    public class UpToDateCheckRequest : RequestBase
    {
        public int AppID { get; set; }
        public int Version { get; set; }
        public UpToDateCheckRequest(string key) : base(key) { }

        protected internal override string EndpointUrl
        {
            get { return "http://api.steampowered.com/ISteamApps/UpToDateCheck/v1"; }
        }

        protected override Infrastructure.Objects.QueryStringDictionary GetParameterList()
        {
            var parameters = base.GetParameterList();
            parameters.Add("appid", this.AppID);
            parameters.Add("version", this.Version);
            return parameters;
        }
    }
}

