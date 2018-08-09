// ------------------------------------------------------------------------------------------------
//  <copyright file="CommunityVisibilityState.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Types
{
    /// <summary>
    ///     Describes the access setting of a player profile.
    /// </summary>
    public enum CommunityVisibilityState
    {
        /// <summary>
        ///     Not visible for you
        /// </summary>
        Private = 1,

        /// <summary>
        ///     This is visible for friends only
        /// </summary>
        FriendsOnly = 2,

        /// <summary>
        ///     Visible for the issuing user.
        /// </summary>
        Public = 3
    }
}