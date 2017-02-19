namespace PortableSteam.Fluent.General.ISteamUserStats
{
    using PortableSteam.Infrastructure;
    using PortableSteam.Interfaces.General.ISteamUserStats;
    using System;
    using System.ComponentModel;

    public class GetGlobalStatsForGameBuilder : SteamBaseBuilder<GetGlobalStatsForGameRequest, GetGlobalStatsForGameResponse, GetGlobalStatsForGameBuilder>
    {
        public GetGlobalStatsForGameBuilder(GetGlobalStatsForGameRequest request) : base(request) { }
        /// <summary>
        /// Start date for daily totals.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public GetGlobalStatsForGameBuilder StartDate(DateTime value)
        {
            this.Request.StartDate = value.ToUnixTimeStamp();
            return this;
        }
        /// <summary>
        /// End date for daily totals.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public GetGlobalStatsForGameBuilder EndDate(DateTime value)
        {
            this.Request.EndDate = value.ToUnixTimeStamp();
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
