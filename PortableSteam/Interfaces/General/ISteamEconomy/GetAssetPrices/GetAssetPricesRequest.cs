namespace PortableSteam.Interfaces.General.ISteamEconomy
{
    using PortableSteam.Infrastructure;
    using PortableSteam.Infrastructure.Objects;

    public class GetAssetPricesRequest : RequestBase
    {
        public GetAssetPricesRequest(string key) : base(key) { }
        protected internal override string EndpointUrl
        {
            get { return "http://api.steampowered.com/ISteamEconomy/GetAssetPrices/v0001/"; }
        }
        public int AppID { get; set; }
        public string Currency { get; set; }

        protected override QueryStringDictionary GetParameterList()
        {
            var parameters = base.GetParameterList();
            parameters.Add("appid", AppID);

            if (!string.IsNullOrEmpty(Currency))
            {
                parameters.Add("currency", Currency);
            }

            return parameters;
        }
    }
}
