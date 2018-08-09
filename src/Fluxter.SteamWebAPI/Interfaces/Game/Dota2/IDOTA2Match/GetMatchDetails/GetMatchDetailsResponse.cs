// ------------------------------------------------------------------------------------------------
//  <copyright file="GetMatchDetailsResponse.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Interfaces.Game.Dota2.IDOTA2Match.GetMatchDetails
{
    using System;
    using System.Collections.Generic;
    using Infrastructure;
    using Infrastructure.Converters;
    using Newtonsoft.Json;

    public class GetMatchDetailsResponse : ResponseBase
    {
        [JsonProperty("result")] public GetMatchDetailsResponseData Data { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetMatchDetailsResponseData
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

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetMatchDetailsResponsePlayer
    {
        /// <summary>
        ///     32-bit account ID.
        /// </summary>
        [JsonProperty("account_id")]
        [JsonConverter(typeof(JsonSteamIdentityAccountConverter))]
        public SteamIdentity Identity { get; set; }

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
        ///     What the values here represent are not yet known.
        /// </summary>
        [JsonProperty("leaver_status")]
        public int LeaverStatus { get; set; }

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
        ///     The amount of damage the player dealt to heroes.
        /// </summary>
        [JsonProperty("hero_damage")]
        public int HeroDamage { get; set; }

        /// <summary>
        ///     The amount of damage the player dealt to towers.
        /// </summary>
        [JsonProperty("tower_damage")]
        public int TowerDamage { get; set; }

        /// <summary>
        ///     The amount of health the player had healed on heroes.
        /// </summary>
        [JsonProperty("hero_healing")]
        public int HeroHealing { get; set; }

        /// <summary>
        ///     The player's level at match end.
        /// </summary>
        [JsonProperty("level")]
        public int Level { get; set; }

        /// <summary>
        ///     A list detailing a player's ability upgrades.
        /// </summary>
        [JsonProperty("ability_upgrades")]
        public List<GetMatchDetailsResponseAbilityUpgrade> AbilityUpgrades { get; set; }

        /// <summary>
        ///     Additional playable units owned by the player.
        /// </summary>
        [JsonProperty("additional_units")]
        public List<GetMatchDetailsResponseAdditionalUnit> AdditionalUnits { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetMatchDetailsResponseAbilityUpgrade
    {
        /// <summary>
        ///     ID of the ability upgraded.
        /// </summary>
        [JsonProperty("ability")]
        public int AbilityID { get; set; }

        /// <summary>
        ///     Time since match start that the ability was upgraded.
        /// </summary>
        [JsonProperty("time")]
        [JsonConverter(typeof(JsonTimeSpanSecondsConverter))]
        public TimeSpan Time { get; set; }

        /// <summary>
        ///     The level of the player at time of upgrading.
        /// </summary>
        [JsonProperty("level")]
        public int Level { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetMatchDetailsResponseAdditionalUnit
    {
        /// <summary>
        ///     The name of the unit
        /// </summary>
        [JsonProperty("unitname")]
        public string UnitName { get; set; }

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
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetMatchDetailsResponsePickBan
    {
        /// <summary>
        ///     Whether this entry is a pick (true) or a ban (false).
        /// </summary>
        [JsonProperty("is_pick")]
        public bool IsPick { get; set; }

        /// <summary>
        ///     The hero's unique ID. A list of hero IDs can be found via the GetHeroes method.
        /// </summary>
        [JsonProperty("hero_id")]
        public int HeroID { get; set; }

        /// <summary>
        ///     The team who chose the pick or ban.
        /// </summary>
        [JsonProperty("team")]
        [JsonConverter(typeof(JsonEnumConverter<Dota2Team>))]
        public Dota2Team Team { get; set; }

        /// <summary>
        ///     The order of which the picks and bans were selected; 0-19.
        /// </summary>
        [JsonProperty("order")]
        public int Order { get; set; }
    }
}