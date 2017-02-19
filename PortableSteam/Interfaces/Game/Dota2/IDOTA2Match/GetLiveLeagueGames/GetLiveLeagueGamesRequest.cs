namespace PortableSteam.Interfaces.Game.Dota2.IDOTA2
{
    using PortableSteam.Infrastructure;

    public class GetLiveLeagueGamesRequest : GameRequest
    {
        public GetLiveLeagueGamesRequest(string key, int appID) : base(key, appID) { }

        protected internal override string EndpointUrl
        {
            get { return string.Format("http://api.steampowered.com/IDOTA2Match_{0}/GetLiveLeagueGames/v1/", base.AppID); }
        }
    }
}
