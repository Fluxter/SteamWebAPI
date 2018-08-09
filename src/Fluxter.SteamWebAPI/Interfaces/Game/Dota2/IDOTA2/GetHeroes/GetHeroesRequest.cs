// ------------------------------------------------------------------------------------------------
//  <copyright file="GetHeroesRequest.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Interfaces.Game.Dota2.IDOTA2.GetHeroes
{
    using Infrastructure.Objects;

    public class GetHeroesRequest : GameRequest
    {
        public GetHeroesRequest(string key, int appID) : base(key, appID)
        {
        }

        public bool ItemizedOnly { get; set; }

        protected internal override string EndpointUrl
        {
            get { return string.Format("http://api.steampowered.com/IEconDOTA2_{0}/GetHeroes/v1/", this.AppID); }
        }

        protected override QueryStringDictionary GetParameterList()
        {
            var parameters = base.GetParameterList();
            parameters.Add("itemizedonly", this.ItemizedOnly);
            return parameters;
        }
    }
}