namespace PortableSteam.Interfaces.General.ISteamUser
{
    using PortableSteam.Infrastructure;

    public class GetUserGroupListRequest : RequestBase
    {
        public GetUserGroupListRequest(string key) : base(key) { }

        protected internal override string EndpointUrl
        {
            get { return "http://api.steampowered.com/ISteamUser/GetUserGroupList/v1"; }
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
