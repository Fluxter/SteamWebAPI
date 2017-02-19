namespace PortableSteam.Fluent.General.ISteamEconomy
{
    using PortableSteam.Fluent;
    using PortableSteam.Interfaces.General.ISteamEconomy;
    using System;
    using System.ComponentModel;

    public class GetAssetPricesBuilder : SteamBaseBuilder<GetAssetPricesRequest, GetAssetPricesResponse, GetAssetPricesBuilder>
    {
        public GetAssetPricesBuilder(GetAssetPricesRequest request) : base(request) { }
        /// <summary>
        /// The ISO 4217 code for currency specific filtering.
        /// </summary>
        /// <see href="http://en.wikipedia.org/wiki/ISO_4217"/>
        /// <param name="currency"></param>
        /// <returns></returns>
        public GetAssetPricesBuilder Currency(string currency)
        {
            this.Request.Currency = currency;
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
