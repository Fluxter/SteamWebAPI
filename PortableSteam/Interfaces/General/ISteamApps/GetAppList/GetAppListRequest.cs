namespace PortableSteam.Interfaces.General.ISteamApps
{
    using PortableSteam.Infrastructure;

    public class GetAppListRequest : RequestBase
    {
        public GetAppListRequest(string key) : base(key) { }

        protected internal override string EndpointUrl
        {
            get { return "http://api.steampowered.com/ISteamApps/GetAppList/v2"; }
        }
    }
}
