// ------------------------------------------------------------------------------------------------
//  <copyright file="GetSchemaURLRequest.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Interfaces.Game.Generic.IEconItems.GetSchemaURL
{
    public class GetSchemaURLRequest : GameRequest
    {
        public GetSchemaURLRequest(string key, int appID) : base(key, appID)
        {
        }

        protected internal override string EndpointUrl
        {
            get { return string.Format("http://api.steampowered.com/IEconItems_{0}/GetSchemaURL/v1/", this.AppID); }
        }
    }
}