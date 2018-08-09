// ------------------------------------------------------------------------------------------------
//  <copyright file="TFPromosBuilderHandler.cs"
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

    public class TFPromosBuilderHandler : GameBaseBuilderHandler
    {
        /// <summary>
        ///     Constructor.
        /// </summary>
        /// <param name="key"></param>
        public TFPromosBuilderHandler(string key, int appID) : base(key, appID)
        {
        }

        /// <summary>
        ///     TODO.
        /// </summary>
        public void GetItemID()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     TODO.
        /// </summary>
        public void GrantItem()
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