namespace PortableSteam.Fluent.Game
{
    using System;
    using System.ComponentModel;

    public class GameBaseBuilderHandler : SteamBaseBuilderHandler
    {
        private int _appID;
        protected int AppID { get { return _appID; } }
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="key"></param>
        public GameBaseBuilderHandler(string key, int appID)
            : base(key)
        {
            _appID = appID;
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
