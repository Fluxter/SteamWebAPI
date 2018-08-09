// ------------------------------------------------------------------------------------------------
//  <copyright file="GetMatchHistoryBuilder.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Fluent.Game.Dota2.IDOTA2
{
    using System;
    using System.ComponentModel;
    using Infrastructure;
    using Interfaces.Game.Dota2.IDOTA2;
    using Interfaces.Game.Dota2.IDOTA2Match.GetMatchHistory;

    public class GetMatchHistoryBuilder : SteamBaseBuilder<GetMatchHistoryRequest, GetMatchHistoryResponse,
        GetMatchHistoryBuilder>
    {
        public GetMatchHistoryBuilder(GetMatchHistoryRequest request) : base(request)
        {
        }

        /// <summary>
        ///     Exact match of a player's display-name at the time of the match.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public GetMatchHistoryBuilder PlayerName(string value)
        {
            this.Request.PlayerName = value;
            return this;
        }

        /// <summary>
        ///     A list of hero IDs can be found via the GetHeroes method.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public GetMatchHistoryBuilder HeroID(int value)
        {
            this.Request.HeroID = value;
            return this;
        }

        /// <summary>
        ///     Game mode to filter.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public GetMatchHistoryBuilder GameMode(Dota2GameMode value)
        {
            this.Request.GameMode = value;
            return this;
        }

        /// <summary>
        ///     Skill bracket for the matches (Ignored if an account ID is specified).
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public GetMatchHistoryBuilder Skill(Dota2Skill value)
        {
            this.Request.Skill = value;
            return this;
        }

        /// <summary>
        ///     Minimum date range for returned matches (rounded to the nearest day).
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public GetMatchHistoryBuilder DateMin(DateTime value)
        {
            this.Request.DateMin = value.ToUnixTimeStamp();
            return this;
        }

        /// <summary>
        ///     Maximum date range for returned matches (rounded to the nearest day).
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public GetMatchHistoryBuilder DateMax(DateTime value)
        {
            this.Request.DateMax = value.ToUnixTimeStamp();
            return this;
        }

        /// <summary>
        ///     Minimum amount of players in a match for the match to be returned.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public GetMatchHistoryBuilder MinPlayers(int value)
        {
            this.Request.MinPlayers = value;
            return this;
        }

        /// <summary>
        ///     Identity of the user to retrieve match history for.
        /// </summary>
        /// <param name="identity"></param>
        /// <returns></returns>
        public GetMatchHistoryBuilder Account(SteamIdentity identity)
        {
            this.Request.AccountID = identity.AccountID;
            return this;
        }

        /// <summary>
        ///     Only return matches from this league. A list of league IDs can be found via the GetLeagueListing method.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public GetMatchHistoryBuilder LeagueID(long value)
        {
            this.Request.LeagueID = value;
            return this;
        }

        /// <summary>
        ///     Start searching for matches equal to or older than this match ID.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public GetMatchHistoryBuilder StartAtMatchID(long value)
        {
            this.Request.StartAtMatchID = value;
            return this;
        }

        /// <summary>
        ///     Amount of matches to include in results (default: 25).
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public GetMatchHistoryBuilder MatchesRequested(int value)
        {
            this.Request.MatchesRequested = value;
            return this;
        }

        /// <summary>
        ///     Whether to limit results to tournament matches.
        /// </summary>
        /// <returns></returns>
        public GetMatchHistoryBuilder TournamentGamesOnly()
        {
            this.Request.TournamentGamesOnly = true;
            return this;
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override string ToString()
        {
            return base.ToString();
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public new Type GetType()
        {
            return this.GetType();
        }
    }
}