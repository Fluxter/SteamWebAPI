// ------------------------------------------------------------------------------------------------
//  <copyright file="GetAssetPricesRequest.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Interfaces.General.ISteamEconomy.GetAssetPrices
{
    using Infrastructure;
    using Infrastructure.Objects;

    public class GetAssetPricesRequest : RequestBase
    {
        public GetAssetPricesRequest(string key) : base(key)
        {
        }

        public int AppID { get; set; }
        public string Currency { get; set; }

        protected internal override string EndpointUrl
        {
            get { return "http://api.steampowered.com/ISteamEconomy/GetAssetPrices/v0001/"; }
        }

        protected override QueryStringDictionary GetParameterList()
        {
            var parameters = base.GetParameterList();
            parameters.Add("appid", this.AppID);

            if (!string.IsNullOrEmpty(this.Currency))
            {
                parameters.Add("currency", this.Currency);
            }

            return parameters;
        }
    }
}