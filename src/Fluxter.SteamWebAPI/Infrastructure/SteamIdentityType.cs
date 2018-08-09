// ------------------------------------------------------------------------------------------------
//  <copyright file="SteamIdentityType.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI
{
    /// <summary>
    ///     Type of steam identity.
    /// </summary>
    public enum SteamIdentityType
    {
        /// <summary>
        ///     64 bit community user id.
        /// </summary>
        Default,

        /// <summary>
        ///     32 bit account id.
        /// </summary>
        Account
    }
}