// ------------------------------------------------------------------------------------------------
//  <copyright file="JsonSteamIdentityAccountConverter.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Infrastructure.Converters
{
    using System;
    using Newtonsoft.Json;

    public class JsonSteamIdentityAccountConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue,
            JsonSerializer serializer)
        {
            return SteamIdentity.FromAccountID(long.Parse(reader.Value.ToNullableString()));
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, ((SteamIdentity) value).AccountID);
        }
    }
}