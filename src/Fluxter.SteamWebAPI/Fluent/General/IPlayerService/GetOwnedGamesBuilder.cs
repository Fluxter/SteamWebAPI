// ------------------------------------------------------------------------------------------------
//  <copyright file="GetOwnedGamesBuilder.cs"
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
    using Interfaces.General.IPlayerService.GetOwnedGames;

    public class
        GetOwnedGamesBuilder : SteamBaseBuilder<GetOwnedGamesRequest, GetOwnedGamesResponse, GetOwnedGamesBuilder>
    {
        public GetOwnedGamesBuilder(GetOwnedGamesRequest request)
            : base(request)
        {
        }

        /// <summary>
        ///     Whether or not to include additional details of apps - name and images.
        /// </summary>
        /// <returns></returns>
        public GetOwnedGamesBuilder IncludeAppInfo()
        {
            this.Request.IncludePlayedFreeGames = true;
            return this;
        }

        /// <summary>
        ///     Whether or not to list free-to-play games in the results.
        /// </summary>
        /// <returns></returns>
        [Obsolete("No longer appears to be supported by Steam.")]
        public GetOwnedGamesBuilder IncludePlayedFreeGames()
        {
            this.Request.IncludeAppInfo = true;
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
        public new Type GetType()
        {
            return this.GetType();
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override string ToString()
        {
            return base.ToString();
        }
    }
}