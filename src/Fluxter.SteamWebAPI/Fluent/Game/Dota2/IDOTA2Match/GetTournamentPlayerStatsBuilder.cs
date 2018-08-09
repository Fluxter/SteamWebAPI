// ------------------------------------------------------------------------------------------------
//  <copyright file="GetTournamentPlayerStatsBuilder.cs"
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
    using Interfaces.Game.Dota2.IDOTA2;
    using Interfaces.Game.Dota2.IDOTA2Match.GetTournamentPlayerStats;

    public class GetTournamentPlayerStatsBuilder : SteamBaseBuilder<GetTournamentPlayerStatsRequest,
        GetTournamentPlayerStatsResponse, GetTournamentPlayerStatsBuilder>
    {
        public GetTournamentPlayerStatsBuilder(GetTournamentPlayerStatsRequest request) : base(request)
        {
        }

        /// <summary>
        ///     A list of hero IDs can be found via the GetHeroes method.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public GetTournamentPlayerStatsBuilder HeroID(int value)
        {
            this.Request.HeroID = value;
            return this;
        }

        /// <summary>
        ///     Only return matches from this league. A list of league IDs can be found via the GetLeagueListing method.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public GetTournamentPlayerStatsBuilder LeagueID(long value)
        {
            this.Request.LeagueID = value;
            return this;
        }

        /// <summary>
        ///     Placeholder - Only return stats between this time frame (parameter format not yet known).
        /// </summary>
        /// <returns></returns>
        public GetTournamentPlayerStatsBuilder TimeFrame()
        {
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