namespace PortableSteam.Fluent.Other
{
    using System;
    using System.ComponentModel;

    public class OtherBuilderHandler : SteamBaseBuilderHandler
    {
        public OtherBuilderHandler(string key) : base(key) { }
        /// <summary>
        /// TODO.
        /// </summary>
        public void ISteamGameServerAccount()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// TODO.
        /// </summary>
        public void ISteamOAuth2()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// TODO.
        /// </summary>
        public void ISteamUserAuth()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// TODO.
        /// </summary>
        public void ISteamWebUserPresenceOAuth()
        {
            throw new NotImplementedException();
        }

        #region Hidden

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override string ToString()
        {
            return base.ToString();
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public new Type GetType()
        {
            return this.GetType();
        }

        #endregion
    }
}
