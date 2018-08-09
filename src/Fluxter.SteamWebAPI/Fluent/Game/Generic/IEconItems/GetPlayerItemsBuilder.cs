// ------------------------------------------------------------------------------------------------
//  <copyright file="GetPlayerItemsBuilder.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Fluent.Game.Generic.IEconItems
{
    using System;
    using System.ComponentModel;
    using Interfaces.Game.Generic.IEconItems;
    using Interfaces.Game.Generic.IEconItems.GetPlayerItems;

    public class
        GetPlayerItemsBuilder : SteamBaseBuilder<GetPlayerItemsRequest, GetPlayerItemsResponse, GetPlayerItemsBuilder>
    {
        public GetPlayerItemsBuilder(GetPlayerItemsRequest request) : base(request)
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