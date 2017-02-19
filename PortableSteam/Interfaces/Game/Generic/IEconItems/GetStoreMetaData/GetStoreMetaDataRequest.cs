namespace PortableSteam.Interfaces.Game.Generic.IEconItems
{
    using PortableSteam.Infrastructure;

    public class GetStoreMetaDataRequest : GameRequest
    {
        public GetStoreMetaDataRequest(string key, int appID) : base(key, appID) { }

        protected internal override string EndpointUrl
        {
            get { return string.Format("http://api.steampowered.com/IEconItems_{0}/GetStoreMetaData/v1/", base.AppID); }
        }
    }
}
