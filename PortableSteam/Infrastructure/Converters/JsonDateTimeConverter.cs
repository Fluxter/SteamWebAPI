namespace PortableSteam.Infrastructure.Converters
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;
    using System;

    public class JsonDateTimeConverter : DateTimeConverterBase
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType != JsonToken.Integer)
            {
                throw new ArgumentException("Wrong Token Type");
            }

            long ticks = (long)reader.Value;
            return ticks.ToDateTime();
        }

        public override void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer)
        {
            serializer.Serialize(writer, ((DateTime)value).ToUnixTimeStamp());
        }
    }
}
