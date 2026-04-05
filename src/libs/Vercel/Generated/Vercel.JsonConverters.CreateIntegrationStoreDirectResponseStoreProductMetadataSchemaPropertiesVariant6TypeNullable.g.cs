#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant6TypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant6Type?>
    {
        /// <inheritdoc />
        public override global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant6Type? Read(
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
                        return global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant6TypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant6Type)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant6Type?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant6Type? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant6TypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
