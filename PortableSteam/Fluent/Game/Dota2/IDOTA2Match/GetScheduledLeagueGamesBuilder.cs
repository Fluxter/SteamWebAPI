namespace PortableSteam.Fluent.Game.Dota2.IDOTA2
{
    using PortableSteam.Fluent;
    using PortableSteam.Infrastructure;
    using PortableSteam.Interfaces.Game.Dota2.IDOTA2;
    using System;
    using System.ComponentModel;

    public class GetScheduledLeagueGamesBuilder : SteamBaseBuilder<GetScheduledLeagueGamesRequest, GetScheduledLeagueGamesResponse, GetScheduledLeagueGamesBuilder>
    {
        public GetScheduledLeagueGamesBuilder(GetScheduledLeagueGamesRequest request) : base(request) { }
        /// <summary>
        /// Minimum date range for returned matches (rounded to the nearest day).
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public GetScheduledLeagueGamesBuilder DateMin(DateTime value)
        {
            this.Request.DateMin = value.ToUnixTimeStamp();
            return this;
        }
        /// <summary>
        /// Maximum date range for returned matches (rounded to the nearest day).
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public GetScheduledLeagueGamesBuilder DateMax(DateTime value)
        {
            this.Request.DateMax = value.ToUnixTimeStamp();
            return this;
        }

        #region Hidden

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

        #endregion
    }
}
