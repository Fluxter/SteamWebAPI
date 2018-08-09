// ------------------------------------------------------------------------------------------------
//  <copyright file="SteamIdentity.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI
{
    /// <summary>
    ///     Steam identity. Wrapper class that encapsulates authentication, authorization and correct parsing of steam ids and
    ///     account ids.
    /// </summary>
    public class SteamIdentity
    {
        private readonly long _value;

        /// <summary>
        ///     Constructor.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="value"></param>
        protected SteamIdentity(SteamIdentityType type, long value)
        {
            this.Type = type;
            this._value = value;
        }

        /// <summary>
        ///     The type of this steam identity instantiated.
        /// </summary>
        public SteamIdentityType Type { get; }

        /// <summary>
        ///     The user's 32 bit account ID.
        /// </summary>
        public long AccountID
        {
            get
            {
                if (this.Type == SteamIdentityType.Default)
                {
                    return this._value - 76561197960265728;
                }

                return this._value;
            }
        }

        /// <summary>
        ///     64 bit Steam Community ID.
        /// </summary>
        public long SteamID
        {
            get { return this.AccountID + 76561197960265728; }
        }

        /// <summary>
        ///     Create a new steam identity from a 32bit account ID.
        /// </summary>
        /// <param name="accountID"></param>
        /// <returns></returns>
        public static SteamIdentity FromAccountID(long accountID)
        {
            return new SteamIdentity(SteamIdentityType.Account, accountID);
        }

        /// <summary>
        ///     Create a new steam identity from a 64bit steam ID.
        /// </summary>
        /// <param name="steamID"></param>
        /// <returns></returns>
        public static SteamIdentity FromSteamID(long steamID)
        {
            return new SteamIdentity(SteamIdentityType.Default, steamID);
        }
    }
}