namespace PortableSteam.Interfaces.Game.Dota2.IDOTA2
{
    using PortableSteam.Infrastructure;

    public class GetMatchDetailsRequest : GameRequest
    {
        public GetMatchDetailsRequest(string key, int appID) : base(key, appID) { }

        protected internal override string EndpointUrl
        {
            get { return string.Format("http://api.steampowered.com/IDOTA2Match_{0}/GetMatchDetails/v1/", base.AppID); }
        }
        public long MatchID { get; set; }
        protected override Infrastructure.Objects.QueryStringDictionary GetParameterList()
        {
            var parameters = base.GetParameterList();
            parameters.Add("match_id", MatchID);
            return parameters;
        }
    }
}
