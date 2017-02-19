namespace PortableSteam.Interfaces.General.IPlayerService
{
    using PortableSteam.Infrastructure;

    public class GetRecentlyPlayedGamesRequest : RequestBase
    {
        public GetRecentlyPlayedGamesRequest(string key) : base(key) { }

        protected internal override string EndpointUrl
        {
            get { return "http://api.steampowered.com/IPlayerService/GetRecentlyPlayedGames/v1"; }
        }
        public long SteamID { get; set; }
        public int Count { get; set; }
        protected override Infrastructure.Objects.QueryStringDictionary GetParameterList()
        {
            var parameters = base.GetParameterList();
            parameters.Add("steamid", SteamID);
            parameters.Add("count", Count);
            return parameters;
        }
    }
}
