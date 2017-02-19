namespace PortableSteam.Interfaces.Game.Generic.IEconItems
{
    using PortableSteam.Infrastructure;

    public class GetSchemaURLRequest : GameRequest
    {
        public GetSchemaURLRequest(string key, int appID) : base(key, appID) { }

        protected internal override string EndpointUrl
        {
            get { return string.Format("http://api.steampowered.com/IEconItems_{0}/GetSchemaURL/v1/", base.AppID); }
        }
    }
}
