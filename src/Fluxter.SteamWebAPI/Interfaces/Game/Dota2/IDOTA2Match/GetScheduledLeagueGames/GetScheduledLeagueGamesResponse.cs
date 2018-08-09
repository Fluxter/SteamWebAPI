// ------------------------------------------------------------------------------------------------
//  <copyright file="GetScheduledLeagueGamesResponse.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Interfaces.Game.Dota2.IDOTA2Match.GetScheduledLeagueGames
{
    using System;
    using System.Collections.Generic;
    using Infrastructure;
    using Infrastructure.Converters;
    using Newtonsoft.Json;

    public class GetScheduledLeagueGamesResponse : ResponseBase
    {
        [JsonProperty("result")] public GetScheduledLeagueGamesResponseData Data { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetScheduledLeagueGamesResponseData
    {
        /// <summary>
        ///     Unique ID for the league of the match being played. A list of league IDs can be found via the GetLeagueListing
        ///     method.
        /// </summary>
        [JsonProperty("league_id")]
        public long LeagueID { get; set; }

        /// <summary>
        ///     Unique ID of the game scheduled.
        /// </summary>
        [JsonProperty("game_id")]
        public long GameID { get; set; }

        /// <summary>
        ///     List of participating teams; empty if not known.
        /// </summary>
        [JsonProperty("teams")]
        public List<GetScheduledLeagueGamesResponseTeam> Teams { get; set; }

        /// <summary>
        ///     DateTime timestamp of when the match began.
        /// </summary>
        [JsonProperty("start_time")]
        [JsonConverter(typeof(JsonDateTimeConverter))]
        public DateTime StartTime { get; set; }

        /// <summary>
        ///     Description of the game.
        /// </summary>
        [JsonProperty("comment")]
        public string Comment { get; set; }

        /// <summary>
        ///     Whether the game is a final or not.
        /// </summary>
        [JsonProperty("final")]
        public bool Final { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetScheduledLeagueGamesResponseTeam
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