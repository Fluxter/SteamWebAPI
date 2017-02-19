namespace PortableSteam.Interfaces.General.IPlayerService
{
    using PortableSteam.Infrastructure;

    public class GetSteamLevelRequest : RequestBase
    {
        public GetSteamLevelRequest(string key) : base(key) { }

        protected internal override string EndpointUrl
        {
            get { return "http://api.steampowered.com/IPlayerService/GetSteamLevel/v1"; }
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
