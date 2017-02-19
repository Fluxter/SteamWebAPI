namespace PortableSteam.Fluent.General.ISteamRemoteStorage
{
    using PortableSteam.Interfaces.General.ISteamRemoteStorage;
    using System;
    using System.ComponentModel;

    public class GetUGCFileDetailsBuilder : SteamBaseBuilder<GetUGCFileDetailsRequest, GetUGCFileDetailsResponse, GetUGCFileDetailsBuilder>
    {
        public GetUGCFileDetailsBuilder(GetUGCFileDetailsRequest request) : base(request) { }
        /// <summary>
        /// If specified, only returns details if the file is owned by the identity specified.
        /// </summary>
        /// <param name="identity"></param>
        /// <returns></returns>
        public GetUGCFileDetailsBuilder Identity(SteamIdentity identity)
        {
            this.Request.SteamID = identity.SteamID;
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
