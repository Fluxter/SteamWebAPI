namespace PortableSteam.Interfaces.Game.Dota2.IDOTA2
{
    using PortableSteam.Infrastructure;
    using PortableSteam.Infrastructure.Objects;

    public class GetMatchHistoryRequest : GameRequest
    {
        public GetMatchHistoryRequest(string key, int appID) : base(key, appID) { }

        protected internal override string EndpointUrl
        {
            get { return string.Format("http://api.steampowered.com/IDOTA2Match_{0}/GetMatchHistory/v1/", base.AppID); }
        }
        public string PlayerName { get; set; }
        public int? HeroID { get; set; }
        public Dota2GameMode GameMode { get; set; }
        public Dota2Skill Skill { get; set; }
        public long? DateMin { get; set; }
        public long? DateMax { get; set; }
        public int? MinPlayers { get; set; }
        public long? AccountID { get; set; }
        public long? LeagueID { get; set; }
        public long? StartAtMatchID { get; set; }
        public int? MatchesRequested { get; set; }
        public bool? TournamentGamesOnly { get; set; }
        protected override QueryStringDictionary GetParameterList()
        {
            var parameters = base.GetParameterList();
            parameters.Add("game_mode", GameMode);
            parameters.Add("skill", Skill);

            if (!string.IsNullOrEmpty(PlayerName)) parameters.Add("player_name", PlayerName);
            if (HeroID.HasValue) parameters.Add("hero_id", HeroID.Value);
            if (DateMin.HasValue) parameters.Add("date_min", DateMin.Value);
            if (DateMax.HasValue) parameters.Add("date_max", DateMax.Value);
            if (MinPlayers.HasValue) parameters.Add("min_players", MinPlayers.Value);
            if (AccountID.HasValue) parameters.Add("account_id", AccountID.Value);
            if (LeagueID.HasValue) parameters.Add("league_id", LeagueID.Value);
            if (StartAtMatchID.HasValue) parameters.Add("start_at_match_id ", StartAtMatchID.Value);
            if (MatchesRequested.HasValue) parameters.Add("matches_requested ", MatchesRequested.Value);
            if (TournamentGamesOnly.HasValue) parameters.Add("tournament_games_only ", TournamentGamesOnly.Value);

            return parameters;
        }
    }
}
