namespace PortableSteam.Interfaces.General.ISteamUser
{
    using PortableSteam.Infrastructure;

    public class GetFriendListRequest : RequestBase
    {
        public GetFriendListRequest(string key) : base(key) { }

        protected internal override string EndpointUrl
        {
            get { return "http://api.steampowered.com/ISteamUser/GetFriendList/v1"; }
        }

        public long SteamID { get; set; }
        public RelationshipType Relationship { get; set; }

        protected override Infrastructure.Objects.QueryStringDictionary GetParameterList()
        {
            var parameters = base.GetParameterList();
            parameters.Add("steamid", SteamID);
            parameters.Add("relationship", Relationship.ToLowerString());
            return parameters;
        }
    }
}
