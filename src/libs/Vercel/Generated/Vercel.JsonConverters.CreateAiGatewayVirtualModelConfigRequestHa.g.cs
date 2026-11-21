#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateAiGatewayVirtualModelConfigRequestHaJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.CreateAiGatewayVirtualModelConfigRequestHa>
    {
        /// <inheritdoc />
        public override global::Vercel.CreateAiGatewayVirtualModelConfigRequestHa Read(
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
                        return global::Vercel.CreateAiGatewayVirtualModelConfigRequestHaExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.CreateAiGatewayVirtualModelConfigRequestHa)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.CreateAiGatewayVirtualModelConfigRequestHa);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.CreateAiGatewayVirtualModelConfigRequestHa value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.CreateAiGatewayVirtualModelConfigRequestHaExtensions.ToValueString(value));
        }
    }
}
