// ------------------------------------------------------------------------------------------------
//  <copyright file="GetAssetClassInfoBuilder.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Fluent.General.ISteamEconomy
{
    using System;
    using System.ComponentModel;
    using Interfaces.General.ISteamEconomy;
    using Interfaces.General.ISteamEconomy.GetAssetClassInfo;

    public class GetAssetClassInfoBuilder : SteamBaseBuilder<GetAssetClassInfoRequest, GetAssetClassInfoResponse,
        GetAssetClassInfoBuilder>
    {
        public GetAssetClassInfoBuilder(GetAssetClassInfoRequest request) : base(request)
        {
        }

        /// <summary>
        ///     Instance ID of the nth class.
        /// </summary>
        /// <param name="instanceIDs"></param>
        /// <returns></returns>
        public GetAssetClassInfoBuilder InstanceIDs(params int[] instanceIDs)
        {
            if (instanceIDs.Length != this.Request.ClassCount)
            {
                throw new ArgumentException("Number of instance ID's must match the class count");
            }

            this.Request.InstanceIDs = instanceIDs;
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