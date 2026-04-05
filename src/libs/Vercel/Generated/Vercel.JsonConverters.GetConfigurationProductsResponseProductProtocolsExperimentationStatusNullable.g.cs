#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetConfigurationProductsResponseProductProtocolsExperimentationStatusNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.GetConfigurationProductsResponseProductProtocolsExperimentationStatus?>
    {
        /// <inheritdoc />
        public override global::Vercel.GetConfigurationProductsResponseProductProtocolsExperimentationStatus? Read(
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
                        return global::Vercel.GetConfigurationProductsResponseProductProtocolsExperimentationStatusExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.GetConfigurationProductsResponseProductProtocolsExperimentationStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.GetConfigurationProductsResponseProductProtocolsExperimentationStatus?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.GetConfigurationProductsResponseProductProtocolsExperimentationStatus? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.GetConfigurationProductsResponseProductProtocolsExperimentationStatusExtensions.ToValueString(value.Value));
            }
        }
    }
}
