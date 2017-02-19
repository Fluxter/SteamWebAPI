namespace PortableSteam.Interfaces.General.IPlayerService
{
    using PortableSteam.Infrastructure;

    public class GetOwnedGamesRequest : RequestBase
    {
        public GetOwnedGamesRequest(string key) : base(key) { }

        protected internal override string EndpointUrl
        {
            get { return "http://api.steampowered.com/IPlayerService/GetOwnedGames/v1"; }
        }
        public long SteamID { get; set; }
        public bool IncludeAppInfo { get; set; }
        public bool IncludePlayedFreeGames { get; set; }
        protected override Infrastructure.Objects.QueryStringDictionary GetParameterList()
        {
            var parameters = base.GetParameterList();
            parameters.Add("steamid", SteamID);
            parameters.Add("include_appinfo", IncludeAppInfo);
            parameters.Add("include_played_free_games", IncludePlayedFreeGames);
            return parameters;
        }
    }
}
