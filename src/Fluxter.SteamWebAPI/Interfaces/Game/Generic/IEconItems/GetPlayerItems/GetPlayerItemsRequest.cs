// ------------------------------------------------------------------------------------------------
//  <copyright file="GetPlayerItemsRequest.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Interfaces.Game.Generic.IEconItems.GetPlayerItems
{
    using Infrastructure.Objects;

    public class GetPlayerItemsRequest : GameRequest
    {
        public GetPlayerItemsRequest(string key, int appID) : base(key, appID)
        {
        }

        public long SteamID { get; set; }

        protected internal override string EndpointUrl
        {
            get
            {
                return string.Format("http://api.steampowered.com/IEconItems_{0}/GetPlayerItems/v0001/", this.AppID);
            }
        }

        protected override QueryStringDictionary GetParameterList()
        {
            var parameters = base.GetParameterList();
            parameters.Add("steamid", this.SteamID);
            return parameters;
        }
    }
}