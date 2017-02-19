namespace PortableSteam.Interfaces.General.IPlayerService
{
    using PortableSteam.Infrastructure;

    public class GetCommunityBadgeProgressRequest : RequestBase
    {
        public GetCommunityBadgeProgressRequest(string key) : base(key) { }

        protected internal override string EndpointUrl
        {
            get { return "http://api.steampowered.com/IPlayerService/GetCommunityBadgeProgress/v1"; }
        }
        public long SteamID { get; set; }
        public int BadgeID { get; set; }
        protected override Infrastructure.Objects.QueryStringDictionary GetParameterList()
        {
            var parameters = base.GetParameterList();
            parameters.Add("steamid", SteamID);
            parameters.Add("badgeid", BadgeID);
            return parameters;
        }
    }
}
