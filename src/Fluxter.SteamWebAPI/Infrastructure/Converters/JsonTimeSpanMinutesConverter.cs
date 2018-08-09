// ------------------------------------------------------------------------------------------------
//  <copyright file="JsonTimeSpanMinutesConverter.cs"
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
    using Newtonsoft.Json.Converters;

    public class JsonTimeSpanMinutesConverter : DateTimeConverterBase
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue,
            JsonSerializer serializer)
        {
            if (reader.TokenType != JsonToken.Integer)
            {
                throw new ArgumentException("Wrong Token Type");
            }

            return TimeSpan.FromMinutes(double.Parse(reader.Value.ToNullableString()));
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, ((TimeSpan) value).TotalMinutes);
        }
    }
}