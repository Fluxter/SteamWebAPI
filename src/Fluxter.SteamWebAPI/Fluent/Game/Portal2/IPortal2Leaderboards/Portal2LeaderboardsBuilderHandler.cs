// ------------------------------------------------------------------------------------------------
//  <copyright file="Portal2LeaderboardsBuilderHandler.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Fluent.Game
{
    using System;
    using System.ComponentModel;

    public class Portal2LeaderboardsBuilderHandler : SteamBaseBuilderHandler
    {
        /// <summary>
        ///     Constructor.
        /// </summary>
        /// <param name="key"></param>
        public Portal2LeaderboardsBuilderHandler(string key) : base(key)
        {
        }

        /// <summary>
        ///     TODO.
        /// </summary>
        public void GetBucketizedData()
        {
            throw new NotImplementedException();
        }

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
    }
}