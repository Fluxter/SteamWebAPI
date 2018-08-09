// ------------------------------------------------------------------------------------------------
//  <copyright file="GetOwnedGamesRequest.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Interfaces.General.IPlayerService.GetOwnedGames
{
    using Infrastructure;
    using Infrastructure.Objects;

    public class GetOwnedGamesRequest : RequestBase
    {
        public GetOwnedGamesRequest(string key) : base(key)
        {
        }

        public long SteamID { get; set; }

        public bool IncludeAppInfo { get; set; }

        public bool IncludePlayedFreeGames { get; set; }

        protected internal override string EndpointUrl => "http://api.steampowered.com/IPlayerService/GetOwnedGames/v1";

        protected override QueryStringDictionary GetParameterList()
        {
            var parameters = base.GetParameterList();
            parameters.Add("steamid", this.SteamID);
            parameters.Add("include_appinfo", this.IncludeAppInfo ? "1" : "0");
            parameters.Add("include_played_free_games", this.IncludePlayedFreeGames ? "1" : "0");
            return parameters;
        }
    }
}