namespace PortableSteam.Infrastructure.Converters
{
    using Newtonsoft.Json;
    using System;
    using System.Linq;

    public class JsonEnumStringConverter<T> : JsonConverter where T : struct
    {
        public override bool CanConvert(System.Type objectType)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.String)
            {
                var enumStrings = Enum.GetNames(typeof(T));

                if (enumStrings.Select(x => x.ToLowerString()).Contains(reader.Value.ToNullableString()))
                {
                    var enumString = enumStrings.SingleOrDefault(x => x.Equals(reader.Value.ToLowerString(), StringComparison.CurrentCultureIgnoreCase));
                    return (T)Enum.Parse(typeof(T), enumString);
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
