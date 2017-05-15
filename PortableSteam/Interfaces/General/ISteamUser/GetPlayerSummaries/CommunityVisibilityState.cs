namespace PortableSteam
{
    /// <summary>
    /// Describes the access setting of a player profile.
    /// </summary>
    public enum CommunityVisibilityState
    {
        /// <summary>
        /// Not visible to the given account (friends only or private)
        /// </summary>
        Private = 1,
        /// <summary>
        /// Public: Visible to everyone
        /// </summary>
        Public = 3
    }
}
