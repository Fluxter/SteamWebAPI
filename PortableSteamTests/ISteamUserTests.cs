// ------------------------------------------------------------------------------------------------
//  <copyright file="ISteamUserTests.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>16.05.2017 - 22:59</created>
// ------------------------------------------------------------------------------------------------

namespace PortableSteamTests
{
    using System;
    using System.IO;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using PortableSteam;

    [TestClass]
    public class ISteamUserTests
    {
        public ISteamUserTests()
        {
            SteamWebAPI.SetGlobalKey(File.ReadAllText("Resources/apikey.txt"));
        }

        [TestMethod]
        public void TestGetPlayerSummaries()
        {
            var accountId = 76561197960287930;
            var steamIdentity = SteamIdentity.FromAccountID(accountId); // Gabe Newell
            var summaries = SteamWebAPI.General().ISteamUser().GetPlayerSummaries(steamIdentity).GetResponse();
            if (summaries.Data.Players[0].Identity.SteamID != accountId)
            {
                throw new Exception("GetPlayerSummaries failed.");
            }
        }
    }
}