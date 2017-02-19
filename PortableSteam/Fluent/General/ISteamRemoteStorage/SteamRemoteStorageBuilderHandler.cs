namespace PortableSteam.Fluent.General
{
    using PortableSteam.Fluent.General.ISteamRemoteStorage;
    using PortableSteam.Infrastructure;
    using PortableSteam.Interfaces.General.ISteamRemoteStorage;
    using System;
    using System.ComponentModel;

    public class SteamRemoteStorageBuilderHandler : SteamBaseBuilderHandler
    {
        public SteamRemoteStorageBuilderHandler(string key) : base(key) { }
        /// <summary>
        /// No documentation.
        /// </summary>
        public void GetCollectionDetails()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// No documentation.
        /// </summary>
        public void GetPublishedFilDetails()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// UGC file size, local filename, and URL.
        /// </summary>
        /// <param name="gameType">Product.</param>
        /// <param name="ugcID">ID of UGC file to get info for.</param>
        /// <returns></returns>
        public GetUGCFileDetailsBuilder GetUGCFileDetails(GameType gameType, long ugcID)
        {
            return this.GetUGCFileDetails((int)gameType, ugcID);
        }
        /// <summary>
        /// UGC file size, local filename, and URL.
        /// </summary>
        /// <param name="appID">AppID of product.</param>
        /// <param name="ugcID">ID of UGC file to get info for.</param>
        /// <returns></returns>
        public GetUGCFileDetailsBuilder GetUGCFileDetails(int appID, long ugcID)
        {
            return new GetUGCFileDetailsBuilder(new GetUGCFileDetailsRequest(this.Key) { AppID = appID, UGCID = ugcID });
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
