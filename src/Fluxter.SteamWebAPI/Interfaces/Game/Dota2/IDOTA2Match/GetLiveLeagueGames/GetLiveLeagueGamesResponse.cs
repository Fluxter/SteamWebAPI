// ------------------------------------------------------------------------------------------------
//  <copyright file="GetLiveLeagueGamesResponse.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Interfaces.Game.Dota2.IDOTA2Match.GetLiveLeagueGames
{
    using System.Collections.Generic;
    using Infrastructure;
    using Infrastructure.Converters;
    using Newtonsoft.Json;

    public class GetLiveLeagueGamesResponse : ResponseBase
    {
        [JsonProperty("result")] public GetLiveLeagueGamesResponseData Data { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetLiveLeagueGamesResponseData
    {
        /// <summary>
        ///     A list of games in-progress.
        /// </summary>
        [JsonProperty("games")]
        public List<GetLiveLeagueGamesResponseGame> Games { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetLiveLeagueGamesResponseGame
    {
        /// <summary>
        ///     The list of players within a game.
        /// </summary>
        [JsonProperty("players")]
        public List<GetLiveLeagueGamesResponsePlayer> Players { get; set; }

        /// <summary>
        ///     Information about the team playing as radiant for this match.
        /// </summary>
        [JsonProperty("radiant_team")]
        public GetLiveLeagueGamesResponseRadiantTeam RadiantTeam { get; set; }

        /// <summary>
        ///     Information about the team playing as dire for this match.
        /// </summary>
        [JsonProperty("dire_team")]
        public GetLiveLeagueGamesResponseDireTeam DireTeam { get; set; }

        /// <summary>
        ///     Unique ID for the matches lobby.
        /// </summary>
        [JsonProperty("lobby_id")]
        public int LobbyID { get; set; }

        /// <summary>
        ///     Number of spectators at time of query.
        /// </summary>
        [JsonProperty("spectators")]
        public int Spectators { get; set; }

        /// <summary>
        ///     <see href="http://wiki.teamfortress.com/wiki/WebAPI/GetLiveLeagueGames#Tower_state" />
        /// </summary>
        [JsonProperty("tower_state")]
        public long TowerState { get; set; }

        /// <summary>
        ///     Unique ID for the league of the match being played. A list of league IDs can be found via the GetLeagueListing
        ///     method.
        /// </summary>
        [JsonProperty("league_id")]
        public long LeagueID { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetLiveLeagueGamesResponsePlayer
    {
        /// <summary>
        ///     SteamIdentity.
        /// </summary>
        [JsonProperty("account_id")]
        [JsonConverter(typeof(JsonSteamIdentityAccountConverter))]
        public SteamIdentity Identity { get; set; }

        /// <summary>
        ///     The player's display name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        ///     The hero's unique ID. A list of hero IDs can be found via the GetHeroes method.
        /// </summary>
        [JsonProperty("hero_id")]
        public int HeroID { get; set; }

        /// <summary>
        ///     What team the player is currently playing as.
        /// </summary>
        [JsonProperty("team")]
        [JsonConverter(typeof(JsonEnumConverter<Dota2Team>))]
        public Dota2Team Team { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetLiveLeagueGamesResponseRadiantTeam
    {
        /// <summary>
        ///     The team's name.
        /// </summary>
        [JsonProperty("team_name")]
        public string TeamName { get; set; }

        /// <summary>
        ///     The team's unique ID.
        /// </summary>
        [JsonProperty("team_id")]
        public int TeamID { get; set; }

        /// <summary>
        ///     The UGC id for the team logo. You can resolve this with the GetUGCFileDetails method.
        /// </summary>
        [JsonProperty("team_logo")]
        public long TeamLogo { get; set; }

        /// <summary>
        ///     Whether the players for this team are all team members.
        /// </summary>
        [JsonProperty("complete")]
        public bool Complete { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetLiveLeagueGamesResponseDireTeam
    {
        /// <summary>
        ///     The team's name.
        /// </summary>
        [JsonProperty("team_name")]
        public string TeamName { get; set; }

        /// <summary>
        ///     The team's unique ID.
        /// </summary>
        [JsonProperty("team_id")]
        public int TeamID { get; set; }

        /// <summary>
        ///     The UGC id for the team logo. You can resolve this with the GetUGCFileDetails method.
        /// </summary>
        [JsonProperty("team_logo")]
        public long TeamLogo { get; set; }

        /// <summary>
        ///     Whether the players for this team are all team members.
        /// </summary>
        [JsonProperty("complete")]
        public bool Complete { get; set; }
    }
}