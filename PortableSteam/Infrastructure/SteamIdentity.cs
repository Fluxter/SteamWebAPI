namespace PortableSteam
{
    /// <summary>
    /// Steam identity. Wrapper class that encapsulates authentication, authorization and correct parsing of steam ids and account ids.
    /// </summary>
    public class SteamIdentity
    {
        private SteamIdentityType _type;
        private long _value;
        /// <summary>
        /// The type of this steam identity instantiated.
        /// </summary>
        public SteamIdentityType Type { get { return _type; } }
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="value"></param>
        protected SteamIdentity(SteamIdentityType type, long value)
        {
            _type = type;
            _value = value;
        }
        /// <summary>
        /// Create a new steam identity from a 32bit account ID.
        /// </summary>
        /// <param name="accountID"></param>
        /// <returns></returns>
        public static SteamIdentity FromAccountID(long accountID)
        {
            return new SteamIdentity(SteamIdentityType.Account, accountID);
        }
        /// <summary>
        /// Create a new steam identity from a 64bit steam ID.
        /// </summary>
        /// <param name="steamID"></param>
        /// <returns></returns>
        public static SteamIdentity FromSteamID(long steamID)
        {
            return new SteamIdentity(SteamIdentityType.Default, steamID);
        }
        /// <summary>
        /// The user's 32 bit account ID.
        /// </summary>
        public long AccountID
        {
            get
            {
                if (this.Type == SteamIdentityType.Default)
                {
                    return (_value - 76561197960265728);
                }
                else
                {
                    return _value;
                }
            }
        }
        /// <summary>
        /// 64 bit Steam Community ID.
        /// </summary>
        public long SteamID
        {
            get { return AccountID + 76561197960265728; }
        }
    }
}
