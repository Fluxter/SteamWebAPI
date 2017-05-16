namespace PortableSteam
{
    /// <summary>
    /// Describes the access setting of a player profile.
    /// </summary>
    public enum CommunityVisibilityState
    {
        /// <summary>
        /// Not visible for you
        /// </summary>
        Private = 1,
        /// <summary>
        /// This is visible for friends only
        /// </summary>
        FriendsOnly = 2,
        /// <summary>
        /// Visible for the issuing user.
        /// </summary>
        Public = 3
    }
}