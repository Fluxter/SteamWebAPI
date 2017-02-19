namespace PortableSteam.Infrastructure.Converters
{
    using Newtonsoft.Json.Linq;
    using PortableSteam.Interfaces.Game.Dota2.IDOTA2;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class JsonGetTeamInfoByTeamIDResponseTeamConverter : JsonCustomConverter<GetTeamInfoByTeamIDResponseTeam>
    {
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
            team.GamesPlayedWithCurrentRoster = int.Parse(jsonObject["games_played_with_current_roster"].ToNullableString());
            team.AdminIdentity = SteamIdentity.FromAccountID(long.Parse(jsonObject["admin_account_id"].ToNullableString()));
            team.PlayerIdentities = new List<SteamIdentity>();
            team.Leagues = new List<GetTeamInfoByTeamIDResponseLeague>();

            var playerAccountIDs = jsonObject.Properties().Where(x => x.Name.Contains("player_"));
            foreach (var playerAccountID in playerAccountIDs)
            {
                team.PlayerIdentities.Add(SteamIdentity.FromAccountID(long.Parse(playerAccountID.Value.ToNullableString())));
            }

            var leagueIDs = jsonObject.Properties().Where(x => x.Name.Contains("league_id"));
            foreach (var leagueID in leagueIDs)
            {
                team.Leagues.Add(new GetTeamInfoByTeamIDResponseLeague() { LeagueID = long.Parse(leagueID.Value.ToNullableString()) });
            }

            return team;
        }

        public override void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer)
        {
            base.WriteJson(writer, value, serializer);
        }
    }
}
