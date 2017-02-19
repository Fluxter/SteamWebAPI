namespace PortableSteam.Interfaces.General.ISteamUserStats
{
    using PortableSteam.Infrastructure;
    using PortableSteam.Infrastructure.Objects;

    public class GetGlobalAchievementPercentagesForAppRequest : RequestBase
    {
        public GetGlobalAchievementPercentagesForAppRequest(string key) : base(key) { }
        protected internal override string EndpointUrl
        {
            get { return "http://api.steampowered.com/ISteamUserStats/GetGlobalAchievementPercentagesForApp/v0002"; }
        }
        public int GameID { get; set; }

        protected override QueryStringDictionary GetParameterList()
        {
            var parameters = base.GetParameterList();
            parameters.Add("gameid", GameID);
            return parameters;
        }
    }
}
