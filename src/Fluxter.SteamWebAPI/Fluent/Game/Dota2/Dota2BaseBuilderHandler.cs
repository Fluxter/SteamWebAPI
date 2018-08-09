// ------------------------------------------------------------------------------------------------
//  <copyright file="Dota2BaseBuilderHandler.cs"
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

    public class Dota2BaseBuilderHandler : SteamBaseBuilderHandler
    {
        /// <summary>
        ///     Constructor.
        /// </summary>
        /// <param name="key"></param>
        public Dota2BaseBuilderHandler(string key) : base(key)
        {
        }

        /// <summary>
        ///     Methods relating to Dota 2.
        /// </summary>
        /// <returns></returns>
        public Dota2BuilderHandler IDOTA2()
        {
            return new Dota2BuilderHandler(this.Key);
        }

        /// <summary>
        ///     Methods relating to Dota 2 matches.
        /// </summary>
        /// <returns></returns>
        public Dota2MatchBuilderHandler IDOTA2Match()
        {
            return new Dota2MatchBuilderHandler(this.Key);
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

        [EditorBrowsable(EditorBrowsableState.Never)]
        public new Type GetType()
        {
            return this.GetType();
        }
    }
}