using System;
using Newtonsoft.Json;

namespace AmChartsNet
{
    public class PlainJsonStringConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(string);
        }
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return reader.Value;
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value.ToString().StartsWith("{{") && value.ToString().EndsWith("}}"))
            {
                var stringValue = (string) value;
                writer.WriteRawValue(stringValue.Substring(2, stringValue.Length - 4));
            }
            else
            {
                writer.WriteValue(value);
            }
        }
    }
}