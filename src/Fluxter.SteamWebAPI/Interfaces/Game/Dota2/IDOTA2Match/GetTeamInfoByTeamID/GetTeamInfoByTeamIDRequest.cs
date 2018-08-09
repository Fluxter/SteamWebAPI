// ------------------------------------------------------------------------------------------------
//  <copyright file="GetTeamInfoByTeamIDRequest.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Interfaces.Game.Dota2.IDOTA2
{
    using Infrastructure.Objects;

    public class GetTeamInfoByTeamIDRequest : GameRequest
    {
        public GetTeamInfoByTeamIDRequest(string key, int appID) : base(key, appID)
        {
        }

        public long? StartAtTeamID { get; set; }
        public int? TeamsRequested { get; set; }

        protected internal override string EndpointUrl
        {
            get
            {
                return string.Format("http://api.steampowered.com/IDOTA2Match_{0}/GetTeamInfoByTeamID/v1/", this.AppID);
            }
        }

        protected override QueryStringDictionary GetParameterList()
        {
            var parameters = base.GetParameterList();
            if (this.StartAtTeamID.HasValue)
            {
                parameters.Add("start_at_team_id", this.StartAtTeamID.Value);
            }

            if (this.TeamsRequested.HasValue)
            {
                parameters.Add("teams_requested", this.TeamsRequested.Value);
            }

            return parameters;
        }
    }
}