// ------------------------------------------------------------------------------------------------
//  <copyright file="GetTournamentPlayerStatsRequest.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Interfaces.Game.Dota2.IDOTA2Match.GetTournamentPlayerStats
{
    using Infrastructure.Objects;

    public class GetTournamentPlayerStatsRequest : GameRequest
    {
        public GetTournamentPlayerStatsRequest(string key, int appID) : base(key, appID)
        {
        }

        public long AccountID { get; set; }
        public long? LeagueID { get; set; }
        public int? HeroID { get; set; }

        protected internal override string EndpointUrl
        {
            get
            {
                return string.Format("http://api.steampowered.com/IDOTA2Match_{0}/GetTournamentPlayerStats/v1/",
                    this.AppID);
            }
        }

        protected override QueryStringDictionary GetParameterList()
        {
            var parameters = base.GetParameterList();
            parameters.Add("account_id", this.AccountID);
            if (this.LeagueID.HasValue)
            {
                parameters.Add("league_id", this.LeagueID.Value);
            }

            if (this.HeroID.HasValue)
            {
                parameters.Add("hero_id", this.HeroID.Value);
            }

            return parameters;
        }
    }
}