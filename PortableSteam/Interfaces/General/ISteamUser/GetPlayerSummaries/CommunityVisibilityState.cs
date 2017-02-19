namespace PortableSteam
{
    /// <summary>
    /// Describes the access setting of a player profile.
    /// </summary>
    public enum CommunityVisibilityState
    {
        /// <summary>
        /// Private.
        /// </summary>
        Private = 1,
        /// <summary>
        /// Friends only.
        /// </summary>
        FriendsOnly = 2,
        /// <summary>
        /// Friends of Friends. Currently this value is also set for "Public" and "Users Only" profiles.
        /// </summary>
        FriendsofFriends = 3,
        /// <summary>
        /// Users Only.
        /// </summary>
        UsersOnly = 4,
        /// <summary>
        /// Public.
        /// </summary>
        Public = 5
    }
}
