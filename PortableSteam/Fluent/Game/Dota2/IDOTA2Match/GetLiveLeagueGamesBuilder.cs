namespace PortableSteam.Fluent.Game.Dota2.IDOTA2
{
    using PortableSteam.Fluent;
    using PortableSteam.Interfaces.Game.Dota2.IDOTA2;
    using System;
    using System.ComponentModel;

    public class GetLiveLeagueGamesBuilder : SteamBaseBuilder<GetLiveLeagueGamesRequest, GetLiveLeagueGamesResponse, GetLiveLeagueGamesBuilder>
    {
        public GetLiveLeagueGamesBuilder(GetLiveLeagueGamesRequest request) : base(request) { }

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
