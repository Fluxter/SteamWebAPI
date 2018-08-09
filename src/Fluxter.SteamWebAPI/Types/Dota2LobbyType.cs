// ------------------------------------------------------------------------------------------------
//  <copyright file="Dota2LobbyType.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI
{
    /// <summary>
    ///     Lobby types for Dota 2.
    /// </summary>
    public enum Dota2LobbyType
    {
        /// <summary>
        ///     Invalid.
        /// </summary>
        Invalid = -1,

        /// <summary>
        ///     Public match making.
        /// </summary>
        PublicMatchmaking = 0,

        /// <summary>
        ///     Practise.
        /// </summary>
        Practise = 1,

        /// <summary>
        ///     Tournamnet.
        /// </summary>
        Tournament = 2,

        /// <summary>
        ///     Tutorial.
        /// </summary>
        Tutorial = 3,

        /// <summary>
        ///     Coop with bots.
        /// </summary>
        CoopWithBots = 4,

        /// <summary>
        ///     Team match.
        /// </summary>
        TeamMatch = 5,

        /// <summary>
        ///     Solo queue.
        /// </summary>
        SoloQueue = 6
    }
}