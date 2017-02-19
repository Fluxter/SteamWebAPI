namespace PortableSteam.Fluent.Game.Dota2.IDOTA2
{
    using PortableSteam.Fluent;
    using PortableSteam.Interfaces.Game.Dota2.IDOTA2;
    using System;
    using System.ComponentModel;

    public class GetMatchHistoryBySequenceNumBuilder : SteamBaseBuilder<GetMatchHistoryBySequenceNumRequest, GetMatchHistoryBySequenceNumResponse, GetMatchHistoryBySequenceNumBuilder>
    {
        public GetMatchHistoryBySequenceNumBuilder(GetMatchHistoryBySequenceNumRequest request) : base(request) { }
        /// <summary>
        /// The match sequence number to start returning results from.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public GetMatchHistoryBySequenceNumBuilder StartAtMatchSequenceNumber(long value)
        {
            this.Request.StartAtMatchSeqNum = value;
            return this;
        }
        /// <summary>
        /// The amount of matches to return.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public GetMatchHistoryBySequenceNumBuilder MatchesRequested(int value)
        {
            this.Request.MatchesRequested = value;
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
