#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetSessionCommandLogsResponseVariant1DataCodeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.GetSessionCommandLogsResponseVariant1DataCode?>
    {
        /// <inheritdoc />
        public override global::Vercel.GetSessionCommandLogsResponseVariant1DataCode? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Vercel.GetSessionCommandLogsResponseVariant1DataCodeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.GetSessionCommandLogsResponseVariant1DataCode)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.GetSessionCommandLogsResponseVariant1DataCode?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.GetSessionCommandLogsResponseVariant1DataCode? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.GetSessionCommandLogsResponseVariant1DataCodeExtensions.ToValueString(value.Value));
            }
        }
    }
}
