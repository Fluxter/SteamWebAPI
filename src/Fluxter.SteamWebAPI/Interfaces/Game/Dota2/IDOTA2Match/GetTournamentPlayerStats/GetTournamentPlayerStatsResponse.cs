// ------------------------------------------------------------------------------------------------
//  <copyright file="GetTournamentPlayerStatsResponse.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Interfaces.Game.Dota2.IDOTA2Match.GetTournamentPlayerStats
{
    using System;
    using System.Collections.Generic;
    using Infrastructure;
    using Infrastructure.Converters;
    using Newtonsoft.Json;

    public class GetTournamentPlayerStatsResponse : ResponseBase
    {
        public enum ResponseStatus
        {
            Success = 1,
            OnlySupportsInternational = 8
        }

        [JsonProperty("result")] public GetTournamentPlayerStatsResponseData Data { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetTournamentPlayerStatsResponseData
    {
        /// <summary>
        ///     Query status.
        /// </summary>
        [JsonProperty("status")]
        [JsonConverter(typeof(JsonEnumConverter<GetTournamentPlayerStatsResponse.ResponseStatus>))]
        public GetTournamentPlayerStatsResponse.ResponseStatus Status { get; set; }

        /// <summary>
        ///     A message explaining the status, should status not be 1.
        /// </summary>
        [JsonProperty("statusdetail")]
        public string StatusDetail { get; set; }

        /// <summary>
        ///     An array of matches.
        /// </summary>
        [JsonProperty("matches")]
        public List<GetTournamentPlayerStatsResponseMatch> Matches { get; set; }

        /// <summary>
        ///     Account identity.
        /// </summary>
        [JsonProperty("account_id")]
        [JsonConverter(typeof(JsonSteamIdentityAccountConverter))]
        public SteamIdentity Identity { get; set; }

        /// <summary>
        ///     Account's current Steam profile name.
        /// </summary>
        [JsonProperty("persona")]
        public string Persona { get; set; }

        /// <summary>
        ///     Number of the matches won.
        /// </summary>
        [JsonProperty("wins")]
        public int Wins { get; set; }

        /// <summary>
        ///     Number of the matches lost.
        /// </summary>
        [JsonProperty("losses")]
        public int Losses { get; set; }

        /// <summary>
        ///     Number of kills across all of the matches.
        /// </summary>
        [JsonProperty("kills")]
        public int Kills { get; set; }

        /// <summary>
        ///     Number of deaths across all of the matches.
        /// </summary>
        [JsonProperty("deaths")]
        public int Deaths { get; set; }

        /// <summary>
        ///     Number of assists across all of the matches.
        /// </summary>
        [JsonProperty("assists")]
        public int Assists { get; set; }

        /// <summary>
        ///     Average number of kills per match.
        /// </summary>
        [JsonProperty("kills_average")]
        public double KillsAverage { get; set; }

        /// <summary>
        ///     Average number of deaths per match.
        /// </summary>
        [JsonProperty("deaths_average")]
        public double DeathsAverage { get; set; }

        /// <summary>
        ///     Average number of assists per match.
        /// </summary>
        [JsonProperty("assists_average")]
        public double AssistsAverage { get; set; }

        /// <summary>
        ///     Average gold per minute across all of the matches.
        /// </summary>
        [JsonProperty("gpm_average")]
        public double GPPerMinAverage { get; set; }

        /// <summary>
        ///     Average experience per minute across all of the matches.
        /// </summary>
        [JsonProperty("xpm_average")]
        public double XPPerMinAverage { get; set; }

        /// <summary>
        ///     Most kills in one of the matches.
        /// </summary>
        [JsonProperty("best_kills")]
        public int BestKills { get; set; }

        /// <summary>
        ///     Which Hero the player was playing when they achieved BestKills. A list of hero IDs can be found via the GetHeroes
        ///     method.
        /// </summary>
        [JsonProperty("best_kills_heroid")]
        public int BestKillsHeroID { get; set; }

        /// <summary>
        ///     Highest gold per minute in one of the matches.
        /// </summary>
        [JsonProperty("best_gpm")]
        public double BestGoldPerMin { get; set; }

        /// <summary>
        ///     Which Hero the player was playing when they achieved BestGoldPerMin. A list of hero IDs can be found via the
        ///     GetHeroes method.
        /// </summary>
        [JsonProperty("best_gpm_heroid")]
        public int BestGoldPerMinHeroID { get; set; }

        /// <summary>
        ///     An array of heroes played.
        /// </summary>
        [JsonProperty("heroes_played")]
        public List<GetTournamentPlayerStatsResponseHero> HeroesPlayed { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetTournamentPlayerStatsResponseHero
    {
        /// <summary>
        ///     The hero's unique ID. A list of hero IDs can be found via the GetHeroes method.
        /// </summary>
        [JsonProperty("id")]
        public int HeroID { get; set; }

        /// <summary>
        ///     Number of matches won with this hero.
        /// </summary>
        [JsonProperty("wins")]
        public int Wins { get; set; }

        /// <summary>
        ///     Number of matches lost with this hero.
        /// </summary>
        [JsonProperty("losses")]
        public int Losses { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetTournamentPlayerStatsResponseMatch
    {
        /// <summary>
        ///     http://wiki.teamfortress.com/wiki/WebAPI/GetMatchDetails#Player_Slot
        /// </summary>
        [JsonProperty("player_slot")]
        public long PlayerSlot { get; set; }

        /// <summary>
        ///     The hero's unique ID. A list of hero IDs can be found via the GetHeroes method.
        /// </summary>
        [JsonProperty("hero_id")]
        public int HeroID { get; set; }

        /// <summary>
        ///     ID of the top-left inventory item.
        /// </summary>
        [JsonProperty("item_0")]
        public int Item0 { get; set; }

        /// <summary>
        ///     ID of the top-center inventory item.
        /// </summary>
        [JsonProperty("item_1")]
        public int Item1 { get; set; }

        /// <summary>
        ///     ID of the top-right inventory item.
        /// </summary>
        [JsonProperty("item_2")]
        public int Item2 { get; set; }

        /// <summary>
        ///     ID of the bottom-left inventory item.
        /// </summary>
        [JsonProperty("item_3")]
        public int Item3 { get; set; }

        /// <summary>
        ///     ID of the bottom-center inventory item.
        /// </summary>
        [JsonProperty("item_4")]
        public int Item4 { get; set; }

        /// <summary>
        ///     ID of the bottom-right inventory item.
        /// </summary>
        [JsonProperty("item_5")]
        public int Item5 { get; set; }

        /// <summary>
        ///     The amount of kills attributed to this player.
        /// </summary>
        [JsonProperty("kills")]
        public int Kills { get; set; }

        /// <summary>
        ///     The amount of times this player died during the match.
        /// </summary>
        [JsonProperty("deaths")]
        public int Deaths { get; set; }

        /// <summary>
        ///     The amount of assists attributed to this player.
        /// </summary>
        [JsonProperty("assists")]
        public int Assists { get; set; }

        /// <summary>
        ///     The amount of gold the player had remaining at the end of the match.
        /// </summary>
        [JsonProperty("gold")]
        public int Gold { get; set; }

        /// <summary>
        ///     The amount of last-hits the player got during the match.
        /// </summary>
        [JsonProperty("last_hits")]
        public int LastHits { get; set; }

        /// <summary>
        ///     The amount of denies the player got during the match.
        /// </summary>
        [JsonProperty("denies")]
        public int Denies { get; set; }

        /// <summary>
        ///     The player's overall gold/minute.
        /// </summary>
        [JsonProperty("gold_per_min")]
        public int GoldPerMin { get; set; }

        /// <summary>
        ///     The player's overall experience/minute.
        /// </summary>
        [JsonProperty("xp_per_min")]
        public int XPPerMin { get; set; }

        /// <summary>
        ///     The amount of gold the player spent during the match.
        /// </summary>
        [JsonProperty("gold_spent")]
        public int GoldSpent { get; set; }

        /// <summary>
        ///     The player's level at match end.
        /// </summary>
        [JsonProperty("level")]
        public int Level { get; set; }

        /// <summary>
        ///     Whether the player won the match or not (values: "true" or "false").
        /// </summary>
        [JsonProperty("win")]
        public bool Win { get; set; }

        /// <summary>
        ///     The matches unique ID.
        /// </summary>
        [JsonProperty("match_id")]
        public long MatchID { get; set; }

        /// <summary>
        ///     The length of the match since the match began.
        /// </summary>
        [JsonProperty("duration")]
        [JsonConverter(typeof(JsonTimeSpanSecondsConverter))]
        public TimeSpan Duration { get; set; }
    }
}