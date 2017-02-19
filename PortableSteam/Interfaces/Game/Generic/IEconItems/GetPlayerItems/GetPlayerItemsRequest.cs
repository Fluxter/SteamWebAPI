namespace PortableSteam.Interfaces.Game.Generic.IEconItems
{
    using PortableSteam.Infrastructure;

    public class GetPlayerItemsRequest : GameRequest
    {
        public GetPlayerItemsRequest(string key, int appID) : base(key, appID) { }

        protected internal override string EndpointUrl
        {
            get { return string.Format("http://api.steampowered.com/IEconItems_{0}/GetPlayerItems/v0001/", base.AppID); }
        }
        public long SteamID { get; set; }
        protected override Infrastructure.Objects.QueryStringDictionary GetParameterList()
        {
            var parameters = base.GetParameterList();
            parameters.Add("steamid", SteamID);
            return parameters;
        }
    }
}
