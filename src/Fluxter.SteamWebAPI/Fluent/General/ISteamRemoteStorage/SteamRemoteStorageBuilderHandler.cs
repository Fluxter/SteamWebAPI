// ------------------------------------------------------------------------------------------------
//  <copyright file="SteamRemoteStorageBuilderHandler.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Fluent.General
{
    using System;
    using System.ComponentModel;
    using Interfaces.General.ISteamRemoteStorage;
    using Interfaces.General.ISteamRemoteStorage.GetUGCFileDetails;
    using ISteamRemoteStorage;

    public class SteamRemoteStorageBuilderHandler : SteamBaseBuilderHandler
    {
        public SteamRemoteStorageBuilderHandler(string key) : base(key)
        {
        }

        /// <summary>
        ///     No documentation.
        /// </summary>
        public void GetCollectionDetails()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     No documentation.
        /// </summary>
        public void GetPublishedFilDetails()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     UGC file size, local filename, and URL.
        /// </summary>
        /// <param name="gameType">Product.</param>
        /// <param name="ugcID">ID of UGC file to get info for.</param>
        /// <returns></returns>
        public GetUGCFileDetailsBuilder GetUGCFileDetails(GameType gameType, long ugcID)
        {
            return this.GetUGCFileDetails((int) gameType, ugcID);
        }

        /// <summary>
        ///     UGC file size, local filename, and URL.
        /// </summary>
        /// <param name="appID">AppID of product.</param>
        /// <param name="ugcID">ID of UGC file to get info for.</param>
        /// <returns></returns>
        public GetUGCFileDetailsBuilder GetUGCFileDetails(int appID, long ugcID)
        {
            return new GetUGCFileDetailsBuilder(new GetUGCFileDetailsRequest(this.Key) {AppID = appID, UGCID = ugcID});
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