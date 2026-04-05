#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class PropertyKeyVariant3TagNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.PropertyKeyVariant3Tag?>
    {
        /// <inheritdoc />
        public override global::Vercel.PropertyKeyVariant3Tag? Read(
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
                        return global::Vercel.PropertyKeyVariant3TagExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.PropertyKeyVariant3Tag)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.PropertyKeyVariant3Tag?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.PropertyKeyVariant3Tag? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.PropertyKeyVariant3TagExtensions.ToValueString(value.Value));
            }
        }
    }
}
