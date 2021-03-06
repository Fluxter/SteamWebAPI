﻿// ------------------------------------------------------------------------------------------------
//  <copyright file="GetLeagueListingRequest.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Interfaces.Game.Dota2.IDOTA2Match.GetLeagueListing
{
    public class GetLeagueListingRequest : GameRequest
    {
        public GetLeagueListingRequest(string key, int appID) : base(key, appID)
        {
        }

        protected internal override string EndpointUrl
        {
            get
            {
                return string.Format("http://api.steampowered.com/IDOTA2Match_{0}/GetLeagueListing/v1/", this.AppID);
            }
        }
    }
}