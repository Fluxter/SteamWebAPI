namespace PortableSteam.Interfaces.General.ISteamWebAPIUtil
{
    using PortableSteam.Infrastructure;

    /// <summary>
    /// Request object for method that lists all available WebAPI interfaces.
    /// </summary>
    public class GetSupportedAPIListRequest : RequestBase
    {
        public GetSupportedAPIListRequest(string key) : base(key) { }

        protected internal override string EndpointUrl
        {
            get { return "http://api.steampowered.com/ISteamWebAPIUtil/GetSupportedAPIList/v0001/"; }
        }
    }
}
