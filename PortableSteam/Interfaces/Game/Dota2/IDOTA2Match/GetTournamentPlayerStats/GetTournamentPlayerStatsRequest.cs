namespace PortableSteam.Interfaces.Game.Dota2.IDOTA2
{
    using PortableSteam.Infrastructure;

    public class GetTournamentPlayerStatsRequest : GameRequest
    {
        public GetTournamentPlayerStatsRequest(string key, int appID) : base(key, appID) { }

        protected internal override string EndpointUrl
        {
            get { return string.Format("http://api.steampowered.com/IDOTA2Match_{0}/GetTournamentPlayerStats/v1/", base.AppID); }
        }
        public long AccountID { get; set; }
        public long? LeagueID { get; set; }
        public int? HeroID { get; set; }
        protected override Infrastructure.Objects.QueryStringDictionary GetParameterList()
        {
            var parameters = base.GetParameterList();
            parameters.Add("account_id", AccountID);
            if (LeagueID.HasValue) parameters.Add("league_id", LeagueID.Value);
            if (HeroID.HasValue) parameters.Add("hero_id", HeroID.Value);
            return parameters;
        }
    }
}
