// ------------------------------------------------------------------------------------------------
//  <copyright file="CustomRequest.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Infrastructure
{
    using Objects;

    public class CustomRequest : RequestBase
    {
        private QueryStringDictionary _parameters;

        public CustomRequest(string key) : base(key)
        {
        }

        public string Interface { get; set; }
        public string Method { get; set; }
        public string Version { get; set; }

        public QueryStringDictionary Parameters
        {
            get
            {
                if (this._parameters == null)
                {
                    this._parameters = new QueryStringDictionary();
                }

                return this._parameters;
            }
            set { this._parameters = value; }
        }

        protected internal override string EndpointUrl
        {
            get
            {
                return string.Format("http://api.steampowered.com/{0}/{1}/{2}", this.Interface, this.Method,
                    this.Version);
            }
        }

        protected override QueryStringDictionary GetParameterList()
        {
            var parameters = base.GetParameterList();
            parameters.AddRange(this.Parameters);
            return parameters;
        }
    }
}