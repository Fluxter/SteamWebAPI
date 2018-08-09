// ------------------------------------------------------------------------------------------------
//  <copyright file="GetRaritiesRequest.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Interfaces.Game.Dota2.IDOTA2.GetRarities
{
    public class GetRaritiesRequest : GameRequest
    {
        public GetRaritiesRequest(string key, int appID) : base(key, appID)
        {
        }

        protected internal override string EndpointUrl
        {
            get { return string.Format("http://api.steampowered.com/IEconDOTA2_{0}/GetRarities/v1/", this.AppID); }
        }
    }
}