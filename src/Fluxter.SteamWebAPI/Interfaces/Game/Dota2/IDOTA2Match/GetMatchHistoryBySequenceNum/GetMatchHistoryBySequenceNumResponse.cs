// ------------------------------------------------------------------------------------------------
//  <copyright file="GetMatchHistoryBySequenceNumResponse.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Interfaces.Game.Dota2.IDOTA2Match.GetMatchHistoryBySequenceNum
{
    using System;
    using System.Collections.Generic;
    using GetMatchDetails;
    using IDOTA2;
    using Infrastructure;
    using Infrastructure.Converters;
    using Newtonsoft.Json;

    public class GetMatchHistoryBySequenceNumResponse : ResponseBase
    {
        [JsonProperty("result")] public GetMatchHistoryBySequenceNumResponseData Data { get; set; }

        public enum ResponseStatus
        {
            Success = 1,
            InvalidMatchRequested = 8
        }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetMatchHistoryBySequenceNumResponseData
    {
        /// <summary>
        ///     Query status.
        /// </summary>
        [JsonProperty("status")]
        [JsonConverter(typeof(JsonEnumConverter<GetMatchHistoryBySequenceNumResponse.ResponseStatus>))]
        public GetMatchHistoryBySequenceNumResponse.ResponseStatus Status { get; set; }

        /// <summary>
        ///     A message explaining the status, should status not be 1.
        /// </summary>
        [JsonProperty("statusdetail")]
        public string StatusDetail { get; set; }

        /// <summary>
        ///     A list of matches.
        /// </summary>
        [JsonProperty("matches")]
        public List<GetMatchDetailsMatch> Matches { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetMatchDetailsMatch
    {
        /// <summary>
        ///     List of players in the match.
        /// </summary>
        [JsonProperty("players")]
        public List<GetMatchDetailsResponsePlayer> Players { get; set; }

        /// <summary>
        ///     The season the game was played in.
        /// </summary>
        [JsonProperty("season")]
        public int Season { get; set; }

        /// <summary>
        ///     Dictates the winner of the match, true for radiant; false for dire.
        /// </summary>
        [JsonProperty("radiant_win")]
        public bool RadiantWin { get; set; }

        /// <summary>
        ///     The length of the match since the match began.
        /// </summary>
        [JsonProperty("duration")]
        [JsonConverter(typeof(JsonTimeSpanSecondsConverter))]
        public TimeSpan Duration { get; set; }

        /// <summary>
        ///     DateTime timestamp of when the match began.
        /// </summary>
        [JsonProperty("start_time")]
        [JsonConverter(typeof(JsonDateTimeConverter))]
        public DateTime StartTime { get; set; }

        /// <summary>
        ///     The matches unique ID.
        /// </summary>
        [JsonProperty("match_id")]
        public long MatchID { get; set; }

        /// <summary>
        ///     A 'sequence number', representing the order in which matches were recorded.
        /// </summary>
        [JsonProperty("match_seq_num")]
        public long MatchSequenceNumber { get; set; }

        /// <summary>
        ///     Tower status. http://wiki.teamfortress.com/wiki/WebAPI/GetMatchDetails#Tower_Status
        /// </summary>
        [JsonProperty("tower_status_radiant")]
        public long TowerStatusRadiant { get; set; }

        /// <summary>
        ///     Tower status. http://wiki.teamfortress.com/wiki/WebAPI/GetMatchDetails#Tower_Status
        /// </summary>
        [JsonProperty("tower_status_dire")]
        public long TowerStatusDire { get; set; }

        /// <summary>
        ///     Barracks status. http://wiki.teamfortress.com/wiki/WebAPI/GetMatchDetails#Barracks_Status
        /// </summary>
        [JsonProperty("barracks_status_radiant")]
        public long BarracksStatusRadiant { get; set; }

        /// <summary>
        ///     Barracks status. http://wiki.teamfortress.com/wiki/WebAPI/GetMatchDetails#Barracks_Status
        /// </summary>
        [JsonProperty("barracks_status_dire")]
        public long BarracksStatusDire { get; set; }

        /// <summary>
        ///     The server cluster the match was played upon. Used for downloading replays of matches.
        /// </summary>
        [JsonProperty("cluster")]
        public long Cluster { get; set; }

        /// <summary>
        ///     The time in seconds since the match began when first-blood occured.
        /// </summary>
        [JsonProperty("first_blood_time")]
        [JsonConverter(typeof(JsonTimeSpanSecondsConverter))]
        public TimeSpan FirstBloodTime { get; set; }

        /// <summary>
        ///     Lobby type.
        /// </summary>
        [JsonProperty("lobby_type")]
        [JsonConverter(typeof(JsonEnumConverter<Dota2LobbyType>))]
        public Dota2LobbyType LobbyType { get; set; }

        /// <summary>
        ///     The amount of human players within the match.
        /// </summary>
        [JsonProperty("human_players")]
        public int HumanPlayers { get; set; }

        /// <summary>
        ///     The league that this match was a part of. A list of league IDs can be found via the GetLeagueListing method.
        /// </summary>
        [JsonProperty("leagueid")]
        public long LeagueID { get; set; }

        /// <summary>
        ///     The number of thumbs-up the game has received by users.
        /// </summary>
        [JsonProperty("positive_votes")]
        public int PositiveVotes { get; set; }

        /// <summary>
        ///     The number of thumbs-down the game has received by users.
        /// </summary>
        [JsonProperty("negative_votes")]
        public int NegativeVotes { get; set; }

        /// <summary>
        ///     Game mode.
        /// </summary>
        [JsonProperty("game_mode")]
        [JsonConverter(typeof(JsonEnumConverter<Dota2GameMode>))]
        public Dota2GameMode GameMode { get; set; }

        /// <summary>
        ///     A list of the picks and bans in the match, if the game mode is Captains Mode.
        /// </summary>
        [JsonProperty("picks_bans")]
        public List<GetMatchDetailsResponsePickBan> PicksAndBans { get; set; }
    }
}