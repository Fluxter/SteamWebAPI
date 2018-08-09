// ------------------------------------------------------------------------------------------------
//  <copyright file="GenericBuilderHandler.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Fluent.Game
{
    using System.ComponentModel;

    public class GenericBuilderHandler : SteamBaseBuilderHandler
    {
        /// <summary>
        ///     Constructor.
        /// </summary>
        /// <param name="key"></param>
        public GenericBuilderHandler(string key) : base(key)
        {
        }

        /// <summary>
        ///     Methods relating to in-game items for supported games.
        /// </summary>
        /// <param name="gameType">Type of game to retrieve.</param>
        /// <returns></returns>
        public EconItemsBuilderHandler IEconItems(GameType gameType)
        {
            return this.IEconItems((int) gameType);
        }

        /// <summary>
        ///     Methods relating to in-game items for supported games.
        /// </summary>
        /// <param name="appID">ID of the app to retrieve.</param>
        /// <returns></returns>
        public EconItemsBuilderHandler IEconItems(int appID)
        {
            return new EconItemsBuilderHandler(this.Key, appID);
        }

        /// <summary>
        ///     TODO.
        /// </summary>
        /// <param name="gameType"></param>
        /// <returns></returns>
        public GCVersionBuilderHandler IGCVersion(GameType gameType)
        {
            return this.IGCVersion((int) gameType);
        }

        /// <summary>
        ///     TODO.
        /// </summary>
        /// <param name="gameType"></param>
        /// <returns></returns>
        public GCVersionBuilderHandler IGCVersion(int appID)
        {
            return new GCVersionBuilderHandler(this.Key, appID);
        }

        /// <summary>
        ///     TODO.
        /// </summary>
        /// <param name="gameType"></param>
        /// <returns></returns>
        public TFPromosBuilderHandler ITFPromos(GameType gameType)
        {
            return this.ITFPromos((int) gameType);
        }

        /// <summary>
        ///     TODO.
        /// </summary>
        /// <param name="appID"></param>
        /// <returns></returns>
        public TFPromosBuilderHandler ITFPromos(int appID)
        {
            return new TFPromosBuilderHandler(this.Key, appID);
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