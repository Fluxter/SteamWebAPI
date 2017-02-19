namespace PortableSteam.Interfaces.General.ISteamRemoteStorage
{
    using PortableSteam.Infrastructure;
    using PortableSteam.Infrastructure.Objects;
    
    public class GetUGCFileDetailsRequest : RequestBase
    {
        public GetUGCFileDetailsRequest(string key) : base(key) { }

        protected internal override string EndpointUrl
        {
            get { return "http://api.steampowered.com/ISteamRemoteStorage/GetUGCFileDetails/v1/"; }
        }
        public long SteamID { get; set; }
        public long UGCID { get; set; }
        public int AppID { get; set; }

        protected override QueryStringDictionary GetParameterList()
        {
            var parameters = base.GetParameterList();
            parameters.Add("ugcid", UGCID);
            parameters.Add("appid", AppID);

            if (SteamID > 0)
            {
                parameters.Add("steamid", SteamID);
            }

            return parameters;
        }
    }
}
