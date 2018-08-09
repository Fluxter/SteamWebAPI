// ------------------------------------------------------------------------------------------------
//  <copyright file="GetHeroesBuilder.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Fluent.Game.Dota2.IDOTA2
{
    using System;
    using System.ComponentModel;
    using Interfaces.Game.Dota2.IDOTA2;
    using Interfaces.Game.Dota2.IDOTA2.GetHeroes;

    /// <summary>
    ///     Get heroes method builder.
    /// </summary>
    public class GetHeroesBuilder : SteamBaseBuilder<GetHeroesRequest, GetHeroesResponse, GetHeroesBuilder>
    {
        /// <summary>
        ///     Constructor.
        /// </summary>
        /// <param name="request"></param>
        public GetHeroesBuilder(GetHeroesRequest request) : base(request)
        {
        }

        /// <summary>
        ///     Return a list of itemized heroes only.
        /// </summary>
        /// <returns></returns>
        public GetHeroesBuilder ItemizedOnly()
        {
            this.Request.ItemizedOnly = true;
            return this;
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