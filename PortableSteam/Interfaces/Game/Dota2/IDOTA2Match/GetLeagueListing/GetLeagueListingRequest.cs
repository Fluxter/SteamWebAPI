namespace PortableSteam.Interfaces.Game.Dota2.IDOTA2
{
    using PortableSteam.Infrastructure;

    public class GetLeagueListingRequest : GameRequest
    {
        public GetLeagueListingRequest(string key, int appID) : base(key, appID) { }

        protected internal override string EndpointUrl
        {
            get { return string.Format("http://api.steampowered.com/IDOTA2Match_{0}/GetLeagueListing/v1/", base.AppID); }
        }
    }
}
