// ------------------------------------------------------------------------------------------------
//  <copyright file="GetNewsForAppRequest.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Interfaces.General.ISteamNews.GetNewsForApp
{
    using Infrastructure;
    using Infrastructure.Objects;

    public class GetNewsForAppRequest : RequestBase
    {
        public GetNewsForAppRequest(string key) : base(key)
        {
        }

        public int AppID { get; set; }
        public int MaxLength { get; set; }
        public int EndDate { get; set; }
        public int Count { get; set; }
        public string Feeds { get; set; }

        protected internal override string EndpointUrl
        {
            get { return "http://api.steampowered.com/ISteamNews/GetNewsForApp/v0002"; }
        }

        protected override QueryStringDictionary GetParameterList()
        {
            var parameters = base.GetParameterList();
            parameters.Add("appid", this.AppID);
            if (this.MaxLength > 0)
            {
                parameters.Add("maxlength", this.MaxLength);
            }

            if (this.EndDate > 0)
            {
                parameters.Add("enddate", this.EndDate);
            }

            parameters.Add("count", this.Count);

            if (!string.IsNullOrEmpty(this.Feeds))
            {
                parameters.Add("feeds", this.Feeds);
            }

            return parameters;
        }
    }
}