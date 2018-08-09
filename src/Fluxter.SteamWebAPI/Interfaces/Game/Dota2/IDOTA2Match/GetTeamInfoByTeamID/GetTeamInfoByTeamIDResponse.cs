// ------------------------------------------------------------------------------------------------
//  <copyright file="GetTeamInfoByTeamIDResponse.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Interfaces.Game.Dota2.IDOTA2Match.GetTeamInfoByTeamID
{
    using System;
    using System.Collections.Generic;
    using Infrastructure;
    using Infrastructure.Converters;
    using Newtonsoft.Json;

    public class GetTeamInfoByTeamIDResponse : ResponseBase
    {
        [JsonProperty("result")] public GetTeamInfoByTeamIDResponseData Data { get; set; }

        public enum ResponseStatus
        {
            Success = 1,
            InvalidTeamRequested = 8
        }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetTeamInfoByTeamIDResponseData
    {
        /// <summary>
        ///     Query status.
        /// </summary>
        [JsonProperty("status")]
        [JsonConverter(typeof(JsonEnumConverter<GetTeamInfoByTeamIDResponse.ResponseStatus>))]
        public GetTeamInfoByTeamIDResponse.ResponseStatus Status { get; set; }

        /// <summary>
        ///     A message explaining the status, should status not be 1.
        /// </summary>
        [JsonProperty("statusdetail")]
        public string StatusDetail { get; set; }

        /// <summary>
        ///     List of participating teams; empty if not known.
        /// </summary>
        [JsonProperty("teams")]
        public List<GetTeamInfoByTeamIDResponseTeam> Teams { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    [JsonConverter(typeof(JsonGetTeamInfoByTeamIDResponseTeamConverter))]
    public sealed class GetTeamInfoByTeamIDResponseTeam
    {
        /// <summary>
        ///     The team's unique ID.
        /// </summary>
        [JsonProperty("team_id")]
        public long TeamID { get; set; }

        /// <summary>
        ///     The team's name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        ///     The team's tag.
        /// </summary>
        [JsonProperty("tag")]
        public string Tag { get; set; }

        /// <summary>
        ///     DateTime timestamp of when the match began.
        /// </summary>
        [JsonProperty("time_created")]
        [JsonConverter(typeof(JsonDateTimeConverter))]
        public DateTime TimeCreated { get; set; }

        /// <summary>
        ///     The team's rating.
        /// </summary>
        [JsonProperty("rating")]
        public string Rating { get; set; }

        /// <summary>
        ///     The UGC id for the team logo. You can resolve this with the GetUGCFileDetails method.
        /// </summary>
        [JsonProperty("logo")]
        public long Logo { get; set; }

        /// <summary>
        ///     The UGC id for the team sponsor logo. You can resolve this with the GetUGCFileDetails method.
        /// </summary>
        [JsonProperty("logo_sponsor")]
        public long LogoSponsor { get; set; }

        /// <summary>
        ///     The team's ISO 3166-1 country-code.
        /// </summary>
        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        /// <summary>
        ///     Whether the players for this team are all team members.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        ///     Amount of matches played with the current roster
        /// </summary>
        [JsonProperty("games_played_with_current_roster")]
        public int GamesPlayedWithCurrentRoster { get; set; }

        /// <summary>
        ///     Identity of the team's admin.
        /// </summary>
        [JsonProperty("admin_account_id")]
        [JsonConverter(typeof(JsonSteamIdentityAccountConverter))]
        public SteamIdentity AdminIdentity { get; set; }

        /// <summary>
        ///     Leagues this team is involved in.
        /// </summary>
        public List<GetTeamInfoByTeamIDResponseLeague> Leagues { get; set; }

        /// <summary>
        ///     Identity of players on this team's roster.
        /// </summary>
        public List<SteamIdentity> PlayerIdentities { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetTeamInfoByTeamIDResponseLeague
    {
        /// <summary>
        ///     The league's unique ID.
        /// </summary>
        public long LeagueID { get; set; }
    }
}