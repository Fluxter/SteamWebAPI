// ------------------------------------------------------------------------------------------------
//  <copyright file="GetScheduledLeagueGamesRequest.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Interfaces.Game.Dota2.IDOTA2Match.GetScheduledLeagueGames
{
    using Infrastructure.Objects;

    public class GetScheduledLeagueGamesRequest : GameRequest
    {
        public GetScheduledLeagueGamesRequest(string key, int appID) : base(key, appID)
        {
        }

        public long? DateMin { get; set; }
        public long? DateMax { get; set; }

        protected internal override string EndpointUrl
        {
            get
            {
                return string.Format("http://api.steampowered.com/IDOTA2Match_{0}/GetScheduledLeagueGames/v1/",
                    this.AppID);
            }
        }

        protected override QueryStringDictionary GetParameterList()
        {
            var parameters = base.GetParameterList();
            if (this.DateMin.HasValue)
            {
                parameters.Add("date_min", this.DateMin.Value);
            }

            if (this.DateMax.HasValue)
            {
                parameters.Add("date_max", this.DateMax.Value);
            }

            return parameters;
        }
    }
}