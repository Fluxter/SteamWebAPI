namespace PortableSteam.Interfaces.General.ISteamWebAPIUtil
{
    using PortableSteam.Infrastructure;

    /// <summary>
    /// Request object for methods relating to the WebAPI itself.
    /// </summary>
    public class GetServerInfoRequest : RequestBase
    {
        public GetServerInfoRequest(string key) : base(key) { }
        protected internal override string EndpointUrl
        {
            get { return "http://api.steampowered.com/ISteamWebAPIUtil/GetServerInfo/v0001/"; }
        }
    }
}
