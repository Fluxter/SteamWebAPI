namespace PortableSteam
{
    /// <summary>
    /// A player's status
    /// </summary>
    public enum PersonaState
    {
        /// <summary>
        /// Also set when the profile is Private.
        /// </summary>
        Offline,
        /// <summary>
        /// Online.
        /// </summary>
        Online,
        /// <summary>
        /// Busy.
        /// </summary>
        Busy,
        /// <summary>
        /// Away.
        /// </summary>
        Away,
        /// <summary>
        /// Snooze.
        /// </summary>
        Snooze,
        /// <summary>
        /// Looking to trade.
        /// </summary>
        LookingToTrade,
        /// <summary>
        /// Looking to play.
        /// </summary>
        LookingToPlay
    }
}
