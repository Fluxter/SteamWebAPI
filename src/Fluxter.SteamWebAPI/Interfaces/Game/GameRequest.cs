// ------------------------------------------------------------------------------------------------
//  <copyright file="GameRequest.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Interfaces.Game
{
    using Infrastructure;

    public abstract class GameRequest : RequestBase
    {
        protected GameRequest(string key, int appID)
            : base(key)
        {
            this.AppID = appID;
        }

        protected int AppID { get; }
    }
}