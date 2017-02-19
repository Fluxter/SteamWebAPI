
namespace PortableSteam.Infrastructure.Converters
{
    using Newtonsoft.Json;
    using System;

    public class JsonSteamIdentityConverter : JsonConverter
    {
        public override bool CanConvert(System.Type objectType)
        {
            throw new System.NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return SteamIdentity.FromSteamID(long.Parse(reader.Value.ToNullableString()));
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, ((SteamIdentity)value).SteamID);
        }
    }
}
