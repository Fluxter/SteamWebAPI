// ------------------------------------------------------------------------------------------------
//  <copyright file="GetAssetClassInfoRequest.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Interfaces.General.ISteamEconomy.GetAssetClassInfo
{
    using Infrastructure;
    using Infrastructure.Objects;

    public class GetAssetClassInfoRequest : RequestBase
    {
        public GetAssetClassInfoRequest(string key) : base(key)
        {
        }

        public int AppID { get; set; }
        public int ClassCount { get; set; }
        public int[] ClassIDs { get; set; }
        public int[] InstanceIDs { get; set; }

        protected internal override string EndpointUrl
        {
            get { return "http://api.steampowered.com/ISteamEconomy/GetAssetClassInfo/v0001/"; }
        }

        protected override QueryStringDictionary GetParameterList()
        {
            var parameters = base.GetParameterList();
            parameters.Add("appid", this.AppID);
            parameters.Add("class_count", this.ClassCount);

            for (int i = 0; i < this.ClassIDs.Length; i++)
            {
                parameters.Add("classid" + i, this.ClassIDs[i]);
            }

            if (this.InstanceIDs != null)
            {
                for (int i = 0; i < this.InstanceIDs.Length; i++)
                {
                    parameters.Add("instanceid" + i, this.InstanceIDs[i]);
                }
            }

            return parameters;
        }
    }
}