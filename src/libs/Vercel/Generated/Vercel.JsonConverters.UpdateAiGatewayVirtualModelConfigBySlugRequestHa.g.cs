#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class UpdateAiGatewayVirtualModelConfigBySlugRequestHaJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.UpdateAiGatewayVirtualModelConfigBySlugRequestHa>
    {
        /// <inheritdoc />
        public override global::Vercel.UpdateAiGatewayVirtualModelConfigBySlugRequestHa Read(
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
                        return global::Vercel.UpdateAiGatewayVirtualModelConfigBySlugRequestHaExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.UpdateAiGatewayVirtualModelConfigBySlugRequestHa)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.UpdateAiGatewayVirtualModelConfigBySlugRequestHa);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.UpdateAiGatewayVirtualModelConfigBySlugRequestHa value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.UpdateAiGatewayVirtualModelConfigBySlugRequestHaExtensions.ToValueString(value));
        }
    }
}
