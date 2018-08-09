// ------------------------------------------------------------------------------------------------
//  <copyright file="SteamUserBuilderHandler.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Fluent.General
{
    using System;
    using System.ComponentModel;
    using System.Linq;
    using Types;
    using Infrastructure;
    using Interfaces.General.ISteamUser;
    using Interfaces.General.ISteamUser.GetFriendList;
    using Interfaces.General.ISteamUser.GetPlayerBans;
    using Interfaces.General.ISteamUser.GetPlayerSummaries;
    using Interfaces.General.ISteamUser.GetUserGroupList;
    using Interfaces.General.ISteamUser.ResolveVanityURL;
    using ISteamUser;

    public class SteamUserBuilderHandler : SteamBaseBuilderHandler
    {
        public SteamUserBuilderHandler(string key) : base(key)
        {
        }

        /// <summary>
        ///     User friend list.
        /// </summary>
        /// <param name="identity">The identity of the user to retrieve a list for.</param>
        /// <param name="relationship">Filter by a given role.</param>
        /// <returns></returns>
        public GetFriendListBuilder GetFriendList(SteamIdentity identity, RelationshipType relationship)
        {
            return new GetFriendListBuilder(
                new GetFriendListRequest(this.Key) {SteamID = identity.SteamID, Relationship = relationship});
        }

        /// <summary>
        ///     Player ban/probation status
        /// </summary>
        /// <param name="identities">List of identities</param>
        /// <returns></returns>
        public GetPlayerBansBuilder GetPlayerBans(params SteamIdentity[] identities)
        {
            string ids = identities.Select(x => x.SteamID).ToDelimitedString(",");
            return new GetPlayerBansBuilder(new GetPlayerBansRequest(this.Key) {SteamIDs = ids});
        }

        /// <summary>
        ///     User profile data.
        /// </summary>
        /// <param name="identities">List of identities</param>
        /// <returns></returns>
        public GetPlayerSummariesBuilder GetPlayerSummaries(params SteamIdentity[] identities)
        {
            string ids = identities.Select(x => x.AccountID).ToDelimitedString(",");
            return new GetPlayerSummariesBuilder(new GetPlayerSummariesRequest(this.Key) {SteamIDs = ids});
        }

        /// <summary>
        ///     User group data.
        /// </summary>
        /// <param name="identity">The identity of the user to retrieve a user group list for.</param>
        /// <returns></returns>
        public GetUserGroupListBuilder GetUserGroupList(SteamIdentity identity)
        {
            return new GetUserGroupListBuilder(new GetUserGroupListRequest(this.Key) {SteamID = identity.SteamID});
        }

        /// <summary>
        ///     Resolve vanity URL parts to a 64 bit ID.
        /// </summary>
        /// <param name="vanityurl">
        ///     The vanity URL part of a user's Steam profile URL. This is the basename of
        ///     http://steamcommunity.com/id/ URLs.
        /// </param>
        /// <returns></returns>
        public ResolveVanityURLBuilder ResolveVanityURL(string vanityurl)
        {
            return new ResolveVanityURLBuilder(new ResolveVanityURLRequest(this.Key) {VanityUrl = vanityurl});
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override string ToString()
        {
            return base.ToString();
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public new Type GetType()
        {
            return this.GetType();
        }
    }
}