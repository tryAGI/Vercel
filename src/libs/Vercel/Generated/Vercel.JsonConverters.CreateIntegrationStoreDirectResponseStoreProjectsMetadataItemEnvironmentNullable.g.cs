#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateIntegrationStoreDirectResponseStoreProjectsMetadataItemEnvironmentNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.CreateIntegrationStoreDirectResponseStoreProjectsMetadataItemEnvironment?>
    {
        /// <inheritdoc />
        public override global::Vercel.CreateIntegrationStoreDirectResponseStoreProjectsMetadataItemEnvironment? Read(
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
                        return global::Vercel.CreateIntegrationStoreDirectResponseStoreProjectsMetadataItemEnvironmentExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.CreateIntegrationStoreDirectResponseStoreProjectsMetadataItemEnvironment)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.CreateIntegrationStoreDirectResponseStoreProjectsMetadataItemEnvironment?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.CreateIntegrationStoreDirectResponseStoreProjectsMetadataItemEnvironment? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.CreateIntegrationStoreDirectResponseStoreProjectsMetadataItemEnvironmentExtensions.ToValueString(value.Value));
            }
        }
    }
}
