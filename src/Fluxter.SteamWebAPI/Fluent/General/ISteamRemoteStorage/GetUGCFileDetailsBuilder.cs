// ------------------------------------------------------------------------------------------------
//  <copyright file="GetUGCFileDetailsBuilder.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Fluent.General.ISteamRemoteStorage
{
    using System;
    using System.ComponentModel;
    using Interfaces.General.ISteamRemoteStorage;
    using Interfaces.General.ISteamRemoteStorage.GetUGCFileDetails;

    public class GetUGCFileDetailsBuilder : SteamBaseBuilder<GetUGCFileDetailsRequest, GetUGCFileDetailsResponse,
        GetUGCFileDetailsBuilder>
    {
        public GetUGCFileDetailsBuilder(GetUGCFileDetailsRequest request) : base(request)
        {
        }

        /// <summary>
        ///     If specified, only returns details if the file is owned by the identity specified.
        /// </summary>
        /// <param name="identity"></param>
        /// <returns></returns>
        public GetUGCFileDetailsBuilder Identity(SteamIdentity identity)
        {
            this.Request.SteamID = identity.SteamID;
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