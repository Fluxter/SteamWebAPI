// ------------------------------------------------------------------------------------------------
//  <copyright file="GetTeamInfoByTeamIDBuilder.cs"
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
    using Interfaces.Game.Dota2.IDOTA2Match.GetTeamInfoByTeamID;

    public class GetTeamInfoByTeamIDBuilder : SteamBaseBuilder<GetTeamInfoByTeamIDRequest, GetTeamInfoByTeamIDResponse,
        GetTeamInfoByTeamIDBuilder>
    {
        public GetTeamInfoByTeamIDBuilder(GetTeamInfoByTeamIDRequest request) : base(request)
        {
        }

        /// <summary>
        ///     The team id to start returning results from.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public GetTeamInfoByTeamIDBuilder StartAtTeamID(long value)
        {
            this.Request.StartAtTeamID = value;
            return this;
        }

        /// <summary>
        ///     The amount of teams to return.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public GetTeamInfoByTeamIDBuilder TeamsRequested(int value)
        {
            this.Request.TeamsRequested = value;
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