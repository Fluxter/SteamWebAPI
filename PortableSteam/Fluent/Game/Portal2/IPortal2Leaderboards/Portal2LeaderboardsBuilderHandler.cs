namespace PortableSteam.Fluent.Game
{
    using System;
    using System.ComponentModel;

    public class Portal2LeaderboardsBuilderHandler : SteamBaseBuilderHandler
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="key"></param>
        public Portal2LeaderboardsBuilderHandler(string key) : base(key) { }
        /// <summary>
        /// TODO.
        /// </summary>
        public void GetBucketizedData()
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

        #endregion
    }
}
