// ------------------------------------------------------------------------------------------------
//  <copyright file="GetGlobalStatsForGameBuilder.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Fluent.General.ISteamUserStats
{
    using System;
    using System.ComponentModel;
    using Infrastructure;
    using Interfaces.General.ISteamUserStats;
    using Interfaces.General.ISteamUserStats.GetGlobalStatsForGame;

    public class GetGlobalStatsForGameBuilder : SteamBaseBuilder<GetGlobalStatsForGameRequest,
        GetGlobalStatsForGameResponse, GetGlobalStatsForGameBuilder>
    {
        public GetGlobalStatsForGameBuilder(GetGlobalStatsForGameRequest request) : base(request)
        {
        }

        /// <summary>
        ///     Start date for daily totals.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public GetGlobalStatsForGameBuilder StartDate(DateTime value)
        {
            this.Request.StartDate = value.ToUnixTimeStamp();
            return this;
        }

        /// <summary>
        ///     End date for daily totals.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public GetGlobalStatsForGameBuilder EndDate(DateTime value)
        {
            this.Request.EndDate = value.ToUnixTimeStamp();
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