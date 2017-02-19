namespace PortableSteam.Interfaces.General.ISteamNews
{
    using PortableSteam.Infrastructure;

    public class GetNewsForAppRequest : RequestBase
    {
        public GetNewsForAppRequest(string key) : base(key) { }
        protected internal override string EndpointUrl
        {
            get { return "http://api.steampowered.com/ISteamNews/GetNewsForApp/v0002"; }
        }
        public int AppID { get; set; }
        public int MaxLength { get; set; }
        public int EndDate { get; set; }
        public int Count { get; set; }
        public string Feeds { get; set; }

        protected override Infrastructure.Objects.QueryStringDictionary GetParameterList()
        {
            var parameters = base.GetParameterList();
            parameters.Add("appid", AppID);
            if (MaxLength > 0)
            {
                parameters.Add("maxlength", MaxLength);
            }

            if (EndDate > 0)
            {
                parameters.Add("enddate", EndDate);
            }

            parameters.Add("count", Count);

            if (!string.IsNullOrEmpty(Feeds))
            {
                parameters.Add("feeds", Feeds);
            }

            return parameters;
        }
    }
}
