// ------------------------------------------------------------------------------------------------
//  <copyright file="GetMatchHistoryBySequenceNumBuilder.cs"
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
    using Interfaces.Game.Dota2.IDOTA2Match.GetMatchHistoryBySequenceNum;

    public class GetMatchHistoryBySequenceNumBuilder : SteamBaseBuilder<GetMatchHistoryBySequenceNumRequest,
        GetMatchHistoryBySequenceNumResponse, GetMatchHistoryBySequenceNumBuilder>
    {
        public GetMatchHistoryBySequenceNumBuilder(GetMatchHistoryBySequenceNumRequest request) : base(request)
        {
        }

        /// <summary>
        ///     The match sequence number to start returning results from.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public GetMatchHistoryBySequenceNumBuilder StartAtMatchSequenceNumber(long value)
        {
            this.Request.StartAtMatchSeqNum = value;
            return this;
        }

        /// <summary>
        ///     The amount of matches to return.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public GetMatchHistoryBySequenceNumBuilder MatchesRequested(int value)
        {
            this.Request.MatchesRequested = value;
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