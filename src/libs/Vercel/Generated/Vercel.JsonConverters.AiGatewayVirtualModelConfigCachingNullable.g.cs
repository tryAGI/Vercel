#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class AiGatewayVirtualModelConfigCachingNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.AiGatewayVirtualModelConfigCaching?>
    {
        /// <inheritdoc />
        public override global::Vercel.AiGatewayVirtualModelConfigCaching? Read(
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
                        return global::Vercel.AiGatewayVirtualModelConfigCachingExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.AiGatewayVirtualModelConfigCaching)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.AiGatewayVirtualModelConfigCaching?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.AiGatewayVirtualModelConfigCaching? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.AiGatewayVirtualModelConfigCachingExtensions.ToValueString(value.Value));
            }
        }
    }
}
