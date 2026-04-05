#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetDeploymentResponseVariant1ImagesRemotePatternProtocolJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.GetDeploymentResponseVariant1ImagesRemotePatternProtocol>
    {
        /// <inheritdoc />
        public override global::Vercel.GetDeploymentResponseVariant1ImagesRemotePatternProtocol Read(
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
                        return global::Vercel.GetDeploymentResponseVariant1ImagesRemotePatternProtocolExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.GetDeploymentResponseVariant1ImagesRemotePatternProtocol)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.GetDeploymentResponseVariant1ImagesRemotePatternProtocol);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.GetDeploymentResponseVariant1ImagesRemotePatternProtocol value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.GetDeploymentResponseVariant1ImagesRemotePatternProtocolExtensions.ToValueString(value));
        }
    }
}
