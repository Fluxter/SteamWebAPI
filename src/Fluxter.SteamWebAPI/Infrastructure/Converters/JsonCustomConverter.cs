// ------------------------------------------------------------------------------------------------
//  <copyright file="JsonCustomConverter.cs"
//             company="fluxter.net">
//       Copyright (c) fluxter.net. All rights reserved.
//  </copyright>
//  <author>Marcel Kallen</author>
//  <created>09.08.2018 - 19:42</created>
// ------------------------------------------------------------------------------------------------

namespace Fluxter.SteamWebAPI.Infrastructure.Converters
{
    using System;
    using System.Reflection;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public abstract class JsonCustomConverter<T> : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return typeof(T).GetTypeInfo().IsAssignableFrom(objectType.GetTypeInfo());
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue,
            JsonSerializer serializer)
        {
            try
            {
                var json = reader.ToNullableString();
                var container = JObject.Load(reader);
                var target = this.Create(objectType, container);
                serializer.Populate(container.CreateReader(), target);
                return target;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        protected abstract T Create(Type objectType, JObject jsonObject);
    }
}