// ------------------------------------------------------------------------------------------------
//  <copyright file="GetMatchHistoryRequest.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Interfaces.Game.Dota2.IDOTA2Match.GetMatchHistory
{
    using Infrastructure.Objects;

    public class GetMatchHistoryRequest : GameRequest
    {
        public GetMatchHistoryRequest(string key, int appID) : base(key, appID)
        {
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

        protected internal override string EndpointUrl
        {
            get { return string.Format("http://api.steampowered.com/IDOTA2Match_{0}/GetMatchHistory/v1/", this.AppID); }
        }

        protected override QueryStringDictionary GetParameterList()
        {
            var parameters = base.GetParameterList();
            parameters.Add("game_mode", this.GameMode);
            parameters.Add("skill", this.Skill);

            if (!string.IsNullOrEmpty(this.PlayerName))
            {
                parameters.Add("player_name", this.PlayerName);
            }

            if (this.HeroID.HasValue)
            {
                parameters.Add("hero_id", this.HeroID.Value);
            }

            if (this.DateMin.HasValue)
            {
                parameters.Add("date_min", this.DateMin.Value);
            }

            if (this.DateMax.HasValue)
            {
                parameters.Add("date_max", this.DateMax.Value);
            }

            if (this.MinPlayers.HasValue)
            {
                parameters.Add("min_players", this.MinPlayers.Value);
            }

            if (this.AccountID.HasValue)
            {
                parameters.Add("account_id", this.AccountID.Value);
            }

            if (this.LeagueID.HasValue)
            {
                parameters.Add("league_id", this.LeagueID.Value);
            }

            if (this.StartAtMatchID.HasValue)
            {
                parameters.Add("start_at_match_id ", this.StartAtMatchID.Value);
            }

            if (this.MatchesRequested.HasValue)
            {
                parameters.Add("matches_requested ", this.MatchesRequested.Value);
            }

            if (this.TournamentGamesOnly.HasValue)
            {
                parameters.Add("tournament_games_only ", this.TournamentGamesOnly.Value);
            }

            return parameters;
        }
    }
}