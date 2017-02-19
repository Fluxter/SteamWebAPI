namespace PortableSteam.Fluent.Game
{
    using System;
    using System.ComponentModel;

    public class TFPromosBuilderHandler : GameBaseBuilderHandler
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="key"></param>
        public TFPromosBuilderHandler(string key, int appID) : base(key, appID) { }
        /// <summary>
        /// TODO.
        /// </summary>
        public void GetItemID()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// TODO.
        /// </summary>
        public void GrantItem()
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
