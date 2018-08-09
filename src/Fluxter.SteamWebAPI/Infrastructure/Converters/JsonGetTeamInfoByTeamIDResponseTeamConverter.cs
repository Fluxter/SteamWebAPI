// ------------------------------------------------------------------------------------------------
//  <copyright file="JsonGetTeamInfoByTeamIDResponseTeamConverter.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Infrastructure.Converters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Interfaces.Game.Dota2.IDOTA2;
    using Interfaces.Game.Dota2.IDOTA2Match.GetTeamInfoByTeamID;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class JsonGetTeamInfoByTeamIDResponseTeamConverter : JsonCustomConverter<GetTeamInfoByTeamIDResponseTeam>
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            base.WriteJson(writer, value, serializer);
        }

        protected override GetTeamInfoByTeamIDResponseTeam Create(Type objectType, JObject jsonObject)
        {
            var team = new GetTeamInfoByTeamIDResponseTeam();
            team.TeamID = long.Parse(jsonObject["team_id"].ToNullableString());
            team.Name = jsonObject["name"].ToNullableString();
            team.Tag = jsonObject["tag"].ToNullableString();
            team.TimeCreated = long.Parse(jsonObject["time_created"].ToNullableString()).ToDateTime();
            team.Rating = jsonObject["rating"].ToNullableString();
            team.Logo = long.Parse(jsonObject["logo"].ToNullableString());
            team.LogoSponsor = long.Parse(jsonObject["logo_sponsor"].ToNullableString());
            team.CountryCode = jsonObject["country_code"].ToNullableString();
            team.Url = jsonObject["url"].ToNullableString();
            team.GamesPlayedWithCurrentRoster =
                int.Parse(jsonObject["games_played_with_current_roster"].ToNullableString());
            team.AdminIdentity =
                SteamIdentity.FromAccountID(long.Parse(jsonObject["admin_account_id"].ToNullableString()));
            team.PlayerIdentities = new List<SteamIdentity>();
            team.Leagues = new List<GetTeamInfoByTeamIDResponseLeague>();

            var playerAccountIDs = jsonObject.Properties().Where(x => x.Name.Contains("player_"));
            foreach (var playerAccountID in playerAccountIDs)
            {
                team.PlayerIdentities.Add(
                    SteamIdentity.FromAccountID(long.Parse(playerAccountID.Value.ToNullableString())));
            }

            var leagueIDs = jsonObject.Properties().Where(x => x.Name.Contains("league_id"));
            foreach (var leagueID in leagueIDs)
            {
                team.Leagues.Add(new GetTeamInfoByTeamIDResponseLeague
                {
                    LeagueID = long.Parse(leagueID.Value.ToNullableString())
                });
            }

            return team;
        }
    }
}