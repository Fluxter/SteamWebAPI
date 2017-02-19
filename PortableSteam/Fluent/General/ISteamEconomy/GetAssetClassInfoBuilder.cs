namespace PortableSteam.Fluent.General.ISteamEconomy
{
    using PortableSteam.Fluent;
    using PortableSteam.Interfaces.General.ISteamEconomy;
    using System;
    using System.ComponentModel;

    public class GetAssetClassInfoBuilder : SteamBaseBuilder<GetAssetClassInfoRequest, GetAssetClassInfoResponse, GetAssetClassInfoBuilder>
    {
        public GetAssetClassInfoBuilder(GetAssetClassInfoRequest request) : base(request) { }
        /// <summary>
        /// Instance ID of the nth class.
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
