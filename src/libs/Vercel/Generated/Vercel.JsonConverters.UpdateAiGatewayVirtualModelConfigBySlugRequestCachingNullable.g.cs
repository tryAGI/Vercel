#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class UpdateAiGatewayVirtualModelConfigBySlugRequestCachingNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.UpdateAiGatewayVirtualModelConfigBySlugRequestCaching?>
    {
        /// <inheritdoc />
        public override global::Vercel.UpdateAiGatewayVirtualModelConfigBySlugRequestCaching? Read(
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
                        return global::Vercel.UpdateAiGatewayVirtualModelConfigBySlugRequestCachingExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.UpdateAiGatewayVirtualModelConfigBySlugRequestCaching)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.UpdateAiGatewayVirtualModelConfigBySlugRequestCaching?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.UpdateAiGatewayVirtualModelConfigBySlugRequestCaching? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.UpdateAiGatewayVirtualModelConfigBySlugRequestCachingExtensions.ToValueString(value.Value));
            }
        }
    }
}
