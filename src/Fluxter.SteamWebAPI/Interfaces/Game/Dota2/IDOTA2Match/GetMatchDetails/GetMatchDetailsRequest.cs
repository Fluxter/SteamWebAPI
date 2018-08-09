// ------------------------------------------------------------------------------------------------
//  <copyright file="GetMatchDetailsRequest.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Interfaces.Game.Dota2.IDOTA2Match.GetMatchDetails
{
    using Infrastructure.Objects;

    public class GetMatchDetailsRequest : GameRequest
    {
        public GetMatchDetailsRequest(string key, int appID) : base(key, appID)
        {
        }

        public long MatchID { get; set; }

        protected internal override string EndpointUrl
        {
            get { return string.Format("http://api.steampowered.com/IDOTA2Match_{0}/GetMatchDetails/v1/", this.AppID); }
        }

        protected override QueryStringDictionary GetParameterList()
        {
            var parameters = base.GetParameterList();
            parameters.Add("match_id", this.MatchID);
            return parameters;
        }
    }
}