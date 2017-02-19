namespace PortableSteam.Interfaces.General.ISteamUser
{
    using PortableSteam.Infrastructure;

    public class GetPlayerBansRequest : RequestBase
    {
        public GetPlayerBansRequest(string key) : base(key) { }

        protected internal override string EndpointUrl
        {
            get { return "http://api.steampowered.com/ISteamUser/GetPlayerBans/v1"; }
        }

        public string SteamIDs { get; set; }

        protected override Infrastructure.Objects.QueryStringDictionary GetParameterList()
        {
            var parameters = base.GetParameterList();
            parameters.Add("steamids", SteamIDs);
            return parameters;
        }
    }
}
