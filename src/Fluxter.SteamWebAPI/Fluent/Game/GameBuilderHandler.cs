// ------------------------------------------------------------------------------------------------
//  <copyright file="GameBuilderHandler.cs"
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

    public class GameBuilderHandler : SteamBaseBuilderHandler
    {
        /// <summary>
        ///     Constructor.
        /// </summary>
        /// <param name="key"></param>
        public GameBuilderHandler(string key) : base(key)
        {
        }

        /// <summary>
        ///     Generic interfaces related to games.
        /// </summary>
        /// <returns></returns>
        public GenericBuilderHandler Generic()
        {
            return new GenericBuilderHandler(this.Key);
        }

        /// <summary>
        ///     Interfaces related to Dota 2.
        /// </summary>
        /// <returns></returns>
        public Dota2BaseBuilderHandler Dota2()
        {
            return new Dota2BaseBuilderHandler(this.Key);
        }

        /// <summary>
        ///     Interfaces related to Portal 2.
        /// </summary>
        /// <returns></returns>
        public Portal2BaseBuilderHandler Portal2()
        {
            return new Portal2BaseBuilderHandler(this.Key);
            ;
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