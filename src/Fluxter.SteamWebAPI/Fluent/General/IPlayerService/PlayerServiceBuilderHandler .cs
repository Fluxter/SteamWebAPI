// ------------------------------------------------------------------------------------------------
//  <copyright file="PlayerServiceBuilderHandler .cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Fluent.General
{
    using System;
    using System.ComponentModel;
    using Interfaces.General.IPlayerService;
    using Interfaces.General.IPlayerService.GetBadges;
    using Interfaces.General.IPlayerService.GetCommunityBadgeProgress;
    using Interfaces.General.IPlayerService.GetOwnedGames;
    using Interfaces.General.IPlayerService.GetRecentlyPlayedGames;
    using Interfaces.General.IPlayerService.GetSteamLevel;
    using IPlayerService;

    public class PlayerServiceBuilderHandler : SteamBaseBuilderHandler
    {
        public PlayerServiceBuilderHandler(string key) : base(key)
        {
        }

        /// <summary>
        ///     Get badges for player.
        /// </summary>
        /// <param name="identity">The identity of the player.</param>
        /// <returns></returns>
        public GetBadgesBuilder GetBadges(SteamIdentity identity)
        {
            return new GetBadgesBuilder(new GetBadgesRequest(this.Key) {SteamID = identity.SteamID});
        }

        /// <summary>
        ///     Get badge progress for player.
        /// </summary>
        /// <param name="identity">The identity of the player.</param>
        /// <returns></returns>
        public GetCommunityBadgeProgressBuilder GetCommunityBadgeProgress(SteamIdentity identity)
        {
            return new GetCommunityBadgeProgressBuilder(
                new GetCommunityBadgeProgressRequest(this.Key) {SteamID = identity.SteamID});
        }

        /// <summary>
        ///     Get owned games for player.
        /// </summary>
        /// <param name="identity">The identity of the player.</param>
        /// <returns></returns>
        public GetOwnedGamesBuilder GetOwnedGames(SteamIdentity identity)
        {
            return new GetOwnedGamesBuilder(new GetOwnedGamesRequest(this.Key) {SteamID = identity.SteamID});
        }

        /// <summary>
        ///     Get recently played games for player.
        /// </summary>
        /// <param name="identity">The identity of the player.</param>
        /// <returns></returns>
        public GetRecentlyPlayedGamesBuilder GetRecentlyPlayedGames(SteamIdentity identity)
        {
            return new GetRecentlyPlayedGamesBuilder(
                new GetRecentlyPlayedGamesRequest(this.Key) {SteamID = identity.SteamID});
        }

        /// <summary>
        ///     Get player level.
        /// </summary>
        /// <param name="identity">The identity of the player.</param>
        /// <returns></returns>
        public GetSteamLevelBuilder GetSteamLevel(SteamIdentity identity)
        {
            return new GetSteamLevelBuilder(new GetSteamLevelRequest(this.Key) {SteamID = identity.SteamID});
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