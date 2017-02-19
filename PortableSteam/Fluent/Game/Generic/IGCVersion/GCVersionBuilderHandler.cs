namespace PortableSteam.Fluent.Game
{
    using System;
    using System.ComponentModel;

    public class GCVersionBuilderHandler : GameBaseBuilderHandler
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="key"></param>
        public GCVersionBuilderHandler(string key, int appID) : base(key, appID) { }
        /// <summary>
        /// TODO.
        /// </summary>
        public void GetClientVersion()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// TODO.
        /// </summary>
        public void GetClusterVersion()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// TODO.
        /// </summary>
        public void GetServerVersion()
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
