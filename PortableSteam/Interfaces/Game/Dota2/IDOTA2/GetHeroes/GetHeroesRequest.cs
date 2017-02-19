namespace PortableSteam.Interfaces.Game.Dota2.IDOTA2
{
    using PortableSteam.Infrastructure;

    public class GetHeroesRequest : GameRequest
    {
        public GetHeroesRequest(string key, int appID) : base(key, appID) { }

        protected internal override string EndpointUrl
        {
            get { return string.Format("http://api.steampowered.com/IEconDOTA2_{0}/GetHeroes/v1/", base.AppID); }
        }
        public bool ItemizedOnly { get; set; }
        protected override Infrastructure.Objects.QueryStringDictionary GetParameterList()
        {
            var parameters = base.GetParameterList();
            parameters.Add("itemizedonly", ItemizedOnly);
            return parameters;
        }
    }
}
