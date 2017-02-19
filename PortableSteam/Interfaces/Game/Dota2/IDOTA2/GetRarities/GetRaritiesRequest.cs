namespace PortableSteam.Interfaces.Game.Dota2.IDOTA2
{
    using PortableSteam.Infrastructure;

    public class GetRaritiesRequest : GameRequest
    {
        public GetRaritiesRequest(string key, int appID) : base(key, appID) { }

        protected internal override string EndpointUrl
        {
            get { return string.Format("http://api.steampowered.com/IEconDOTA2_{0}/GetRarities/v1/", base.AppID); }
        }
    }
}
