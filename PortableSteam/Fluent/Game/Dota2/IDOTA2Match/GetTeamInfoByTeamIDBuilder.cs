namespace PortableSteam.Fluent.Game.Dota2.IDOTA2
{
    using PortableSteam.Fluent;
    using PortableSteam.Interfaces.Game.Dota2.IDOTA2;
    using System;
    using System.ComponentModel;

    public class GetTeamInfoByTeamIDBuilder : SteamBaseBuilder<GetTeamInfoByTeamIDRequest, GetTeamInfoByTeamIDResponse, GetTeamInfoByTeamIDBuilder>
    {
        public GetTeamInfoByTeamIDBuilder(GetTeamInfoByTeamIDRequest request) : base(request) { }
        /// <summary>
        /// The team id to start returning results from.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public GetTeamInfoByTeamIDBuilder StartAtTeamID(long value)
        {
            this.Request.StartAtTeamID = value;
            return this;
        }
        /// <summary>
        /// The amount of teams to return.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public GetTeamInfoByTeamIDBuilder TeamsRequested(int value)
        {
            this.Request.TeamsRequested = value;
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
