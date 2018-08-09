// ------------------------------------------------------------------------------------------------
//  <copyright file="PersonaState.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Types
{
    /// <summary>
    ///     A player's status
    /// </summary>
    public enum PersonaState
    {
        /// <summary>
        ///     Also set when the profile is Private.
        /// </summary>
        Offline,

        /// <summary>
        ///     Online.
        /// </summary>
        Online,

        /// <summary>
        ///     Busy.
        /// </summary>
        Busy,

        /// <summary>
        ///     Away.
        /// </summary>
        Away,

        /// <summary>
        ///     Snooze.
        /// </summary>
        Snooze,

        /// <summary>
        ///     Looking to trade.
        /// </summary>
        LookingToTrade,

        /// <summary>
        ///     Looking to play.
        /// </summary>
        LookingToPlay
    }
}