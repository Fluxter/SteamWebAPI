// ------------------------------------------------------------------------------------------------
//  <copyright file="EconItemsQuality.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI
{
    /// <summary>
    ///     An object containing the numeric values corresponding to each "quality" an item can have:
    /// </summary>
    public enum EconItemsQuality
    {
        /// <summary>
        ///     Normal - Set on stock items.
        /// </summary>
        Normal,

        /// <summary>
        ///     Genuine - Set on items acquired for a promotional event (for example, Sun-On-A-Stick and Sharpened Volcano
        ///     Fragment).
        /// </summary>
        Rarity1,

        /// <summary>
        ///     Unused.
        /// </summary>
        Rarity2,

        /// <summary>
        ///     Vintage - Set on items with an effect attached or that were gained from a Halloween event.
        /// </summary>
        Vintage3,

        /// <summary>
        ///     Unused.
        /// </summary>
        Rarity3,

        /// <summary>
        ///     Unusual - Set on items with an effect attached or that were gained from a Halloween event.
        /// </summary>
        Rarity4,

        /// <summary>
        ///     Unique - Set on the most common items including those found via drops and crafting.
        /// </summary>
        Unique,

        /// <summary>
        ///     Community - Set on items granted to community contributors.
        /// </summary>
        Community,

        /// <summary>
        ///     Valve - Set on items owned by Valve staff members.
        /// </summary>
        Developer,

        /// <summary>
        ///     Self-Made - Set on items owned by 3rd-party content creators.
        /// </summary>
        SelfMade,

        /// <summary>
        ///     Unused.
        /// </summary>
        Customized,

        /// <summary>
        ///     Strange - Set on ranked items.
        /// </summary>
        Strange,

        /// <summary>
        ///     Unused.
        /// </summary>
        Completed,

        /// <summary>
        ///     Haunted - Set on Halloween items.
        /// </summary>
        Haunted,

        /// <summary>
        ///     Unused.
        /// </summary>
        ToborA
    }
}