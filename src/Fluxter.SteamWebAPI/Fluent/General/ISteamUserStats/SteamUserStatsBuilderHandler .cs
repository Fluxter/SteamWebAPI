// ------------------------------------------------------------------------------------------------
//  <copyright file="SteamUserStatsBuilderHandler .cs"
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
    using Interfaces.General.ISteamUserStats;
    using Interfaces.General.ISteamUserStats.GetGlobalAchievementPercentagesForApp;
    using Interfaces.General.ISteamUserStats.GetGlobalStatsForGame;
    using Interfaces.General.ISteamUserStats.GetNumberOfCurrentPlayers;
    using Interfaces.General.ISteamUserStats.GetPlayerAchievements;
    using Interfaces.General.ISteamUserStats.GetSchemaForGame;
    using Interfaces.General.ISteamUserStats.GetUserStatsForGame;
    using ISteamUserStats;

    public class SteamUserStatsBuilderHandler : SteamBaseBuilderHandler
    {
        public SteamUserStatsBuilderHandler(string key) : base(key)
        {
        }

        /// <summary>
        ///     Statistics showing how much of the player base have unlocked various achievements.
        /// </summary>
        /// <param name="gameType">Game type to retrieve achievement percentages for.</param>
        /// <returns></returns>
        public GetGlobalAchievementPercentagesForAppBuilder GetGlobalAchievementPercentagesForApp(GameType gameType)
        {
            return this.GetGlobalAchievementPercentagesForApp((int) gameType);
        }

        /// <summary>
        ///     Statistics showing how much of the player base have unlocked various achievements.
        /// </summary>
        /// <param name="gameID">
        ///     The ID of the game to retrieve achievement percentages for. This can be the ID of any Steamworks
        ///     game with achievements available.
        /// </param>
        /// <returns></returns>
        public GetGlobalAchievementPercentagesForAppBuilder GetGlobalAchievementPercentagesForApp(int gameID)
        {
            return new GetGlobalAchievementPercentagesForAppBuilder(
                new GetGlobalAchievementPercentagesForAppRequest(this.Key) {GameID = gameID});
        }

        /// <summary>
        ///     Get global stats for game.
        /// </summary>
        /// <param name="gameType">Game type to retrieve global stats for.</param>
        /// <param name="count">Number of stats to get data for.</param>
        /// <param name="names">Names of the stats to get.</param>
        /// <returns></returns>
        public GetGlobalStatsForGameBuilder GetGlobalStatsForGame(GameType gameType, int count, params string[] names)
        {
            return this.GetGlobalStatsForGame((int) gameType, count, names);
        }

        /// <summary>
        /// </summary>
        /// <param name="gameID">
        ///     The ID of the game to retrieve global stats for. This can be the ID of any Steamworks game with
        ///     global stats available.
        /// </param>
        /// <param name="count">Number of stats to get data for.</param>
        /// <param name="names">Names of the stats to get.</param>
        /// <returns></returns>
        public GetGlobalStatsForGameBuilder GetGlobalStatsForGame(int gameID, int count, params string[] names)
        {
            if (names.Length <= 0)
            {
                throw new ArgumentException("Names must be supplied.");
            }

            if (count != names.Length)
            {
                throw new ArgumentException("Count must equal the number of names supplied.");
            }

            return new GetGlobalStatsForGameBuilder(
                new GetGlobalStatsForGameRequest(this.Key) {AppID = gameID, Count = count, Names = names});
        }

        /// <summary>
        ///     Returns the current number of players for an app.
        /// </summary>
        /// <param name="gameType">App that we're getting user count for.</param>
        /// <returns></returns>
        public GetNumberOfCurrentPlayersBuilder GetNumberOfCurrentPlayers(GameType gameType)
        {
            return this.GetNumberOfCurrentPlayers((int) gameType);
        }

        /// <summary>
        ///     Returns the current number of players for an app.
        /// </summary>
        /// <param name="appID">AppID that we're getting user count for.</param>
        /// <returns></returns>
        public GetNumberOfCurrentPlayersBuilder GetNumberOfCurrentPlayers(int appID)
        {
            return new GetNumberOfCurrentPlayersBuilder(new GetNumberOfCurrentPlayersRequest(this.Key) {AppID = appID});
        }

        /// <summary>
        ///     Returns the current number of players for an app.
        /// </summary>
        /// <param name="gameType">App that we're getting achievements for.</param>
        /// <param name="identity">Identity of user.</param>
        /// <returns></returns>
        public GetPlayerAchievementsBuilder GetPlayerAchievements(GameType gameType, SteamIdentity identity)
        {
            return this.GetPlayerAchievements((int) gameType, identity);
        }

        /// <summary>
        ///     Returns the current number of players for an app.
        /// </summary>
        /// <param name="appID">AppID that we're getting achievements for.</param>
        /// <param name="identity">Identity of user.</param>
        /// <returns></returns>
        public GetPlayerAchievementsBuilder GetPlayerAchievements(int appID, SteamIdentity identity)
        {
            return new GetPlayerAchievementsBuilder(
                new GetPlayerAchievementsRequest(this.Key) {AppID = appID, SteamID = identity.SteamID});
        }

        /// <summary>
        ///     Get schema for game.
        /// </summary>
        /// <param name="gameType">App that we're getting schema for.</param>
        /// <returns></returns>
        public GetSchemaForGameBuilder GetSchemaForGame(GameType gameType)
        {
            return this.GetSchemaForGame((int) gameType);
        }

        /// <summary>
        ///     Get schema for game.
        /// </summary>
        /// <param name="appID">AppID that we're getting schema for.</param>
        /// <returns></returns>
        public GetSchemaForGameBuilder GetSchemaForGame(int appID)
        {
            return new GetSchemaForGameBuilder(new GetSchemaForGameRequest(this.Key) {AppID = appID});
        }

        /// <summary>
        ///     Returns the user stats for game.
        /// </summary>
        /// <param name="gameType">App that we're getting achievements for.</param>
        /// <param name="identity">Identity of user</param>
        /// <returns></returns>
        public GetUserStatsForGameBuilder GetUserStatsForGame(GameType gameType, SteamIdentity identity)
        {
            return this.GetUserStatsForGame((int) gameType, identity);
        }

        /// <summary>
        ///     Returns the user stats for game.
        /// </summary>
        /// <param name="appID">AppID that we're getting achievements for.</param>
        /// <param name="identity">Identity of user.</param>
        /// <returns></returns>
        public GetUserStatsForGameBuilder GetUserStatsForGame(int appID, SteamIdentity identity)
        {
            return new GetUserStatsForGameBuilder(
                new GetUserStatsForGameRequest(this.Key) {AppID = appID, SteamID = identity.SteamID});
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