#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetConfigurationsResponseVariant2ItemIntegrationTagIdJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.GetConfigurationsResponseVariant2ItemIntegrationTagId>
    {
        /// <inheritdoc />
        public override global::Vercel.GetConfigurationsResponseVariant2ItemIntegrationTagId Read(
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
                        return global::Vercel.GetConfigurationsResponseVariant2ItemIntegrationTagIdExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.GetConfigurationsResponseVariant2ItemIntegrationTagId)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.GetConfigurationsResponseVariant2ItemIntegrationTagId);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.GetConfigurationsResponseVariant2ItemIntegrationTagId value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.GetConfigurationsResponseVariant2ItemIntegrationTagIdExtensions.ToValueString(value));
        }
    }
}
