// ------------------------------------------------------------------------------------------------
//  <copyright file="GetScheduledLeagueGamesBuilder.cs"
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
    using Interfaces.Game.Dota2.IDOTA2Match.GetScheduledLeagueGames;

    public class GetScheduledLeagueGamesBuilder : SteamBaseBuilder<GetScheduledLeagueGamesRequest,
        GetScheduledLeagueGamesResponse, GetScheduledLeagueGamesBuilder>
    {
        public GetScheduledLeagueGamesBuilder(GetScheduledLeagueGamesRequest request) : base(request)
        {
        }

        /// <summary>
        ///     Minimum date range for returned matches (rounded to the nearest day).
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public GetScheduledLeagueGamesBuilder DateMin(DateTime value)
        {
            this.Request.DateMin = value.ToUnixTimeStamp();
            return this;
        }

        /// <summary>
        ///     Maximum date range for returned matches (rounded to the nearest day).
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public GetScheduledLeagueGamesBuilder DateMax(DateTime value)
        {
            this.Request.DateMax = value.ToUnixTimeStamp();
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