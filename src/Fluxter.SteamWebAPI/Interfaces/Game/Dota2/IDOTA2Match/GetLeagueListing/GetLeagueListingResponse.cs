// ------------------------------------------------------------------------------------------------
//  <copyright file="GetLeagueListingResponse.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Interfaces.Game.Dota2.IDOTA2Match.GetLeagueListing
{
    using System.Collections.Generic;
    using Infrastructure;
    using Newtonsoft.Json;

    public class GetLeagueListingResponse : ResponseBase
    {
        [JsonProperty("result")] public GetLeagueListingResponseData Data { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetLeagueListingResponseData
    {
        /// <summary>
        ///     A list of leagues supported in-game via DotaTV.
        /// </summary>
        [JsonProperty("leagues")]
        public List<GetLeagueListingResponseLeague> Leagues { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public sealed class GetLeagueListingResponseLeague
    {
        /// <summary>
        ///     The name of the league.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        ///     The league's unique ID.
        /// </summary>
        [JsonProperty("league_id")]
        public long LeagueID { get; set; }

        /// <summary>
        ///     A description of the league.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        ///     The league's website.
        /// </summary>
        [JsonProperty("tournament_url")]
        public string TournamentUrl { get; set; }
    }
}