// ------------------------------------------------------------------------------------------------
//  <copyright file="GetBadgesBuilder.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Fluent.General.IPlayerService
{
    using System;
    using System.ComponentModel;
    using Interfaces.General.IPlayerService.GetBadges;

    public class GetBadgesBuilder : SteamBaseBuilder<GetBadgesRequest, GetBadgesResponse, GetBadgesBuilder>
    {
        public GetBadgesBuilder(GetBadgesRequest request) : base(request)
        {
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