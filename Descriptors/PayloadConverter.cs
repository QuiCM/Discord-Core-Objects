using Newtonsoft.Json;
using System;
using System.Reflection;

namespace Discord.Descriptors
{
    public class PayloadConverter : JsonConverter
    {
        public static JsonSerializer ReadDeserializer { get; set; } = JsonSerializer.CreateDefault();
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(object);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            object obj = ReadDeserializer.Deserialize(reader, objectType);
            
            return null;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value);
        }
    }
}