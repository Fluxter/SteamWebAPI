namespace PortableSteam.Interfaces.General.IPlayerService
{
    using PortableSteam.Infrastructure;

    public class GetBadgesRequest : RequestBase
    {
        public GetBadgesRequest(string key) : base(key) { }

        protected internal override string EndpointUrl
        {
            get { return "http://api.steampowered.com/IPlayerService/GetBadges/v1"; }
        }
        public long SteamID { get; set; }
        protected override Infrastructure.Objects.QueryStringDictionary GetParameterList()
        {
            var parameters = base.GetParameterList();
            parameters.Add("steamid", SteamID);
            return parameters;
        }
    }
}
