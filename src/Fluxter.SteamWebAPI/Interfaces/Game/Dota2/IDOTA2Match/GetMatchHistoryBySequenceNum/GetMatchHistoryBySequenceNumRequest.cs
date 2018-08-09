// ------------------------------------------------------------------------------------------------
//  <copyright file="GetMatchHistoryBySequenceNumRequest.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Interfaces.Game.Dota2.IDOTA2Match.GetMatchHistoryBySequenceNum
{
    using Infrastructure.Objects;

    public class GetMatchHistoryBySequenceNumRequest : GameRequest
    {
        public GetMatchHistoryBySequenceNumRequest(string key, int appID) : base(key, appID)
        {
        }

        public long? StartAtMatchSeqNum { get; set; }
        public int? MatchesRequested { get; set; }

        protected internal override string EndpointUrl
        {
            get
            {
                return string.Format("http://api.steampowered.com/IDOTA2Match_{0}/GetMatchHistoryBySequenceNum/v1/",
                    this.AppID);
            }
        }

        protected override QueryStringDictionary GetParameterList()
        {
            var parameters = base.GetParameterList();
            if (this.StartAtMatchSeqNum.HasValue)
            {
                parameters.Add("start_at_match_seq_num", this.StartAtMatchSeqNum);
            }

            if (this.MatchesRequested.HasValue)
            {
                parameters.Add("matches_requested ", this.MatchesRequested);
            }

            return parameters;
        }
    }
}