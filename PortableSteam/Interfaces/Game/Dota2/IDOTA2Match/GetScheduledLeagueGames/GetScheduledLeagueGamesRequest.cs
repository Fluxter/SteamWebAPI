namespace PortableSteam.Interfaces.Game.Dota2.IDOTA2
{
    using PortableSteam.Infrastructure;

    public class GetScheduledLeagueGamesRequest : GameRequest
    {
        public GetScheduledLeagueGamesRequest(string key, int appID) : base(key, appID) { }

        protected internal override string EndpointUrl
        {
            get { return string.Format("http://api.steampowered.com/IDOTA2Match_{0}/GetScheduledLeagueGames/v1/", base.AppID); }
        }
        public long? DateMin { get; set; }
        public long? DateMax { get; set; }
        protected override Infrastructure.Objects.QueryStringDictionary GetParameterList()
        {
            var parameters = base.GetParameterList();
            if (DateMin.HasValue) parameters.Add("date_min", DateMin.Value);
            if (DateMax.HasValue) parameters.Add("date_max", DateMax.Value);
            return parameters;
        }
    }
}
