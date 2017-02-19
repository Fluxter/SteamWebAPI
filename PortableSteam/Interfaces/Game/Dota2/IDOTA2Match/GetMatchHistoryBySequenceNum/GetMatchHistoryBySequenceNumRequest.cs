namespace PortableSteam.Interfaces.Game.Dota2.IDOTA2
{
    using PortableSteam.Infrastructure;

    public class GetMatchHistoryBySequenceNumRequest : GameRequest
    {
        public GetMatchHistoryBySequenceNumRequest(string key, int appID) : base(key, appID) { }

        protected internal override string EndpointUrl
        {
            get { return string.Format("http://api.steampowered.com/IDOTA2Match_{0}/GetMatchHistoryBySequenceNum/v1/", base.AppID); }
        }
        public long? StartAtMatchSeqNum { get; set; }
        public int? MatchesRequested { get; set; }
        protected override Infrastructure.Objects.QueryStringDictionary GetParameterList()
        {
            var parameters = base.GetParameterList();
            if (StartAtMatchSeqNum.HasValue) parameters.Add("start_at_match_seq_num", StartAtMatchSeqNum);
            if (MatchesRequested.HasValue) parameters.Add("matches_requested ", MatchesRequested);
            return parameters;
        }
    }
}
