namespace PortableSteam.Fluent.General.IPlayerService
{
    using PortableSteam.Fluent;
    using PortableSteam.Interfaces.General.IPlayerService;
    using System;
    using System.ComponentModel;

    public class GetRecentlyPlayedGamesBuilder : SteamBaseBuilder<GetRecentlyPlayedGamesRequest, GetRecentlyPlayedGamesResponse, GetRecentlyPlayedGamesBuilder>
    {
        public GetRecentlyPlayedGamesBuilder(GetRecentlyPlayedGamesRequest request) : base(request) { }
        /// <summary>
        /// The number of games to return.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public GetRecentlyPlayedGamesBuilder Count(int value)
        {
            this.Request.Count = value;
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
