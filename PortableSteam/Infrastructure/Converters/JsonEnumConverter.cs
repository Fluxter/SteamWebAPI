namespace PortableSteam.Infrastructure.Converters
{
    using Newtonsoft.Json;
    using System;

    public class JsonEnumConverter<T> : JsonConverter where T : struct
    {
        public override bool CanConvert(System.Type objectType)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return (T)Enum.ToObject(typeof(T), reader.Value);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, (int)Enum.Parse(typeof(T), value.ToNullableString()));
        }
    }
}
