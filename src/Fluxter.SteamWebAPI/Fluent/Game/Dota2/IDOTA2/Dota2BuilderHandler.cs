// ------------------------------------------------------------------------------------------------
//  <copyright file="Dota2BuilderHandler.cs"
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
    using Dota2.IDOTA2;
    using Interfaces.Game.Dota2.IDOTA2;
    using Interfaces.Game.Dota2.IDOTA2.GetHeroes;
    using Interfaces.Game.Dota2.IDOTA2.GetRarities;

    public class Dota2BuilderHandler : GameBaseBuilderHandler
    {
        /// <summary>
        ///     Constructor.
        /// </summary>
        /// <param name="key"></param>
        public Dota2BuilderHandler(string key) : base(key, (int) GameType.Dota2)
        {
        }

        /// <summary>
        ///     Dota 2 item rarity list.
        /// </summary>
        public GetRaritiesBuilder GetRarities()
        {
            return new GetRaritiesBuilder(new GetRaritiesRequest(this.Key, this.AppID));
        }

        /// <summary>
        ///     A list of heroes within Dota 2.
        /// </summary>
        public GetHeroesBuilder GetHeroes()
        {
            return new GetHeroesBuilder(new GetHeroesRequest(this.Key, this.AppID));
        }

        /// <summary>
        ///     TODO.
        /// </summary>
        public void GetTicketSaleStatus()
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

        [EditorBrowsable(EditorBrowsableState.Never)]
        public new Type GetType()
        {
            return this.GetType();
        }
    }
}