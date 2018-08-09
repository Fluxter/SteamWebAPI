// ------------------------------------------------------------------------------------------------
//  <copyright file="GetBadgesRequest.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Interfaces.General.IPlayerService.GetBadges
{
    using Infrastructure;
    using Infrastructure.Objects;

    public class GetBadgesRequest : RequestBase
    {
        public GetBadgesRequest(string key) : base(key)
        {
        }

        public long SteamID { get; set; }

        protected internal override string EndpointUrl
        {
            get { return "http://api.steampowered.com/IPlayerService/GetBadges/v1"; }
        }

        protected override QueryStringDictionary GetParameterList()
        {
            var parameters = base.GetParameterList();
            parameters.Add("steamid", this.SteamID);
            return parameters;
        }
    }
}