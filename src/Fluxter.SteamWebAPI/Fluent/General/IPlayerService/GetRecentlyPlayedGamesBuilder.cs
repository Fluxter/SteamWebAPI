// ------------------------------------------------------------------------------------------------
//  <copyright file="GetRecentlyPlayedGamesBuilder.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Fluent.General.IPlayerService
{
    using System;
    using System.ComponentModel;
    using Interfaces.General.IPlayerService;
    using Interfaces.General.IPlayerService.GetRecentlyPlayedGames;

    public class GetRecentlyPlayedGamesBuilder : SteamBaseBuilder<GetRecentlyPlayedGamesRequest,
        GetRecentlyPlayedGamesResponse, GetRecentlyPlayedGamesBuilder>
    {
        public GetRecentlyPlayedGamesBuilder(GetRecentlyPlayedGamesRequest request) : base(request)
        {
        }

        /// <summary>
        ///     The number of games to return.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public GetRecentlyPlayedGamesBuilder Count(int value)
        {
            this.Request.Count = value;
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