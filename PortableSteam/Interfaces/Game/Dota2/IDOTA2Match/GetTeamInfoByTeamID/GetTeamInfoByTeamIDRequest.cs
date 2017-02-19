namespace PortableSteam.Interfaces.Game.Dota2.IDOTA2
{
    using PortableSteam.Infrastructure;

    public class GetTeamInfoByTeamIDRequest : GameRequest
    {
        public GetTeamInfoByTeamIDRequest(string key, int appID) : base(key, appID) { }

        protected internal override string EndpointUrl
        {
            get { return string.Format("http://api.steampowered.com/IDOTA2Match_{0}/GetTeamInfoByTeamID/v1/", base.AppID); }
        }
        public long? StartAtTeamID { get; set; }
        public int? TeamsRequested { get; set; }
        protected override Infrastructure.Objects.QueryStringDictionary GetParameterList()
        {
            var parameters = base.GetParameterList();
            if (StartAtTeamID.HasValue) parameters.Add("start_at_team_id", StartAtTeamID.Value);
            if (TeamsRequested.HasValue) parameters.Add("teams_requested", TeamsRequested.Value);
            return parameters;
        }
    }
}
