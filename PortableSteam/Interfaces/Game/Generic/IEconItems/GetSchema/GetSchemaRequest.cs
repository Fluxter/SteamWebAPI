namespace PortableSteam.Interfaces.Game.Generic.IEconItems
{
    using PortableSteam.Infrastructure;

    public class GetSchemaRequest : GameRequest
    {
        public GetSchemaRequest(string key, int appID) : base(key, appID) { }

        protected internal override string EndpointUrl
        {
            get { return string.Format("http://api.steampowered.com/IEconItems_{0}/GetSchema/v0001/", base.AppID); }
        }
    }
}
