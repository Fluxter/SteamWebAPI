namespace PortableSteam.Fluent.Game
{
    using PortableSteam.Fluent.Game.Dota2.IDOTA2;
    using PortableSteam.Interfaces.Game.Dota2.IDOTA2;
    using System;
    using System.ComponentModel;

    public class Dota2BuilderHandler : GameBaseBuilderHandler
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="key"></param>
        public Dota2BuilderHandler(string key) : base(key, (int)GameType.Dota2) { }
        /// <summary>
        /// Dota 2 item rarity list.
        /// </summary>
        public GetRaritiesBuilder GetRarities()
        {
            return new GetRaritiesBuilder(new GetRaritiesRequest(this.Key, this.AppID));
        }
        /// <summary>
        /// A list of heroes within Dota 2.
        /// </summary>
        public GetHeroesBuilder GetHeroes()
        {
            return new GetHeroesBuilder(new GetHeroesRequest(this.Key, this.AppID));
        }
        /// <summary>
        /// TODO.
        /// </summary>
        public void GetTicketSaleStatus()
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
        [EditorBrowsable(EditorBrowsableState.Never)]
        public new Type GetType()
        {
            return this.GetType();
        }

        #endregion
    }
}
