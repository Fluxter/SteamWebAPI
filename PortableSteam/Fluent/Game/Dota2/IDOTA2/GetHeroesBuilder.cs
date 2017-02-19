namespace PortableSteam.Fluent.Game.Dota2.IDOTA2
{
    using PortableSteam.Fluent;
    using PortableSteam.Interfaces.Game.Dota2.IDOTA2;
    using System;
    using System.ComponentModel;

    /// <summary>
    /// Get heroes method builder.
    /// </summary>
    public class GetHeroesBuilder : SteamBaseBuilder<GetHeroesRequest, GetHeroesResponse, GetHeroesBuilder>
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="request"></param>
        public GetHeroesBuilder(GetHeroesRequest request) : base(request) { }
        /// <summary>
        /// Return a list of itemized heroes only.
        /// </summary>
        /// <returns></returns>
        public GetHeroesBuilder ItemizedOnly()
        {
            this.Request.ItemizedOnly = true;
            return this;
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
