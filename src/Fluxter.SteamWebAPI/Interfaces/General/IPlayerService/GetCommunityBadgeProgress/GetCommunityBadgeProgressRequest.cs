// ------------------------------------------------------------------------------------------------
//  <copyright file="GetCommunityBadgeProgressRequest.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Interfaces.General.IPlayerService.GetCommunityBadgeProgress
{
    using Infrastructure;
    using Infrastructure.Objects;

    public class GetCommunityBadgeProgressRequest : RequestBase
    {
        public GetCommunityBadgeProgressRequest(string key) : base(key)
        {
        }

        public long SteamID { get; set; }
        public int BadgeID { get; set; }

        protected internal override string EndpointUrl
        {
            get { return "http://api.steampowered.com/IPlayerService/GetCommunityBadgeProgress/v1"; }
        }

        protected override QueryStringDictionary GetParameterList()
        {
            var parameters = base.GetParameterList();
            parameters.Add("steamid", this.SteamID);
            parameters.Add("badgeid", this.BadgeID);
            return parameters;
        }
    }
}