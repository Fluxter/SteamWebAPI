﻿namespace PortableSteam.Fluent.Game
{
    using System;
    using System.ComponentModel;

    public class Portal2BaseBuilderHandler : SteamBaseBuilderHandler
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="key"></param>
        public Portal2BaseBuilderHandler(string key) : base(key) { }
        /// <summary>
        /// Methods relating to Portal 2 Leaderboards.
        /// </summary>
        /// <returns></returns>
        public Portal2LeaderboardsBuilderHandler IPortal2LeaderBoards()
        {
            return new Portal2LeaderboardsBuilderHandler(this.Key);
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
