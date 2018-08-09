// ------------------------------------------------------------------------------------------------
//  <copyright file="JsonEnumStringConverter.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Infrastructure.Converters
{
    using System;
    using System.Linq;
    using Newtonsoft.Json;

    public class JsonEnumStringConverter<T> : JsonConverter where T : struct
    {
        public override bool CanConvert(Type objectType)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue,
            JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.String)
            {
                var enumStrings = Enum.GetNames(typeof(T));

                if (enumStrings.Select(x => x.ToLowerString()).Contains(reader.Value.ToNullableString()))
                {
                    var enumString = enumStrings.SingleOrDefault(x =>
                        x.Equals(reader.Value.ToLowerString(), StringComparison.CurrentCultureIgnoreCase));
                    return (T) Enum.Parse(typeof(T), enumString);
                }
            }

            return null;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value.ToLowerString());
        }
    }
}