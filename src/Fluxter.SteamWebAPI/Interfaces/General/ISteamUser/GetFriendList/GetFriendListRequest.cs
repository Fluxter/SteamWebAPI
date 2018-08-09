// ------------------------------------------------------------------------------------------------
//  <copyright file="GetFriendListRequest.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Interfaces.General.ISteamUser.GetFriendList
{
    using Types;
    using Infrastructure;
    using Infrastructure.Objects;

    public class GetFriendListRequest : RequestBase
    {
        public GetFriendListRequest(string key) : base(key)
        {
        }

        public long SteamID { get; set; }
        public RelationshipType Relationship { get; set; }

        protected internal override string EndpointUrl
        {
            get { return "http://api.steampowered.com/ISteamUser/GetFriendList/v1"; }
        }

        protected override QueryStringDictionary GetParameterList()
        {
            var parameters = base.GetParameterList();
            parameters.Add("steamid", this.SteamID);
            parameters.Add("relationship", this.Relationship.ToLowerString());
            return parameters;
        }
    }
}