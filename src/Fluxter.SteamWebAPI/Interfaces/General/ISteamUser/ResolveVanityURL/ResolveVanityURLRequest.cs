// ------------------------------------------------------------------------------------------------
//  <copyright file="ResolveVanityURLRequest.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Interfaces.General.ISteamUser.ResolveVanityURL
{
    using Types;
    using Infrastructure;
    using Infrastructure.Objects;

    public class ResolveVanityURLRequest : RequestBase
    {
        public ResolveVanityURLRequest(string key) : base(key)
        {
        }

        public string VanityUrl { get; set; }
        public RelationshipType Relationship { get; set; }

        protected internal override string EndpointUrl
        {
            get { return "http://api.steampowered.com/ISteamUser/ResolveVanityURL/v1"; }
        }

        protected override QueryStringDictionary GetParameterList()
        {
            var parameters = base.GetParameterList();
            parameters.Add("vanityurl", this.VanityUrl);
            return parameters;
        }
    }
}