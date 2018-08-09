// ------------------------------------------------------------------------------------------------
//  <copyright file="Dota2Skill.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI
{
    /// <summary>
    ///     Dota 2 skill level. Used for match history filter.
    /// </summary>
    public enum Dota2Skill
    {
        /// <summary>
        ///     Any.
        /// </summary>
        Any,

        /// <summary>
        ///     Normal.
        /// </summary>
        Normal,

        /// <summary>
        ///     High.
        /// </summary>
        High,

        /// <summary>
        ///     Very high.
        /// </summary>
        VeryHigh
    }
}