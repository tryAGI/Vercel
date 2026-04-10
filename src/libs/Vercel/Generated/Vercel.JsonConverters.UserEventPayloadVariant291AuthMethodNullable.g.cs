#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class UserEventPayloadVariant291AuthMethodNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.UserEventPayloadVariant291AuthMethod?>
    {
        /// <inheritdoc />
        public override global::Vercel.UserEventPayloadVariant291AuthMethod? Read(
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
                        return global::Vercel.UserEventPayloadVariant291AuthMethodExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.UserEventPayloadVariant291AuthMethod)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.UserEventPayloadVariant291AuthMethod?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.UserEventPayloadVariant291AuthMethod? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.UserEventPayloadVariant291AuthMethodExtensions.ToValueString(value.Value));
            }
        }
    }
}
