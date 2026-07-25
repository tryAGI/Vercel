#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class ImportConnectorTokensConnectEnvironmentNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.ImportConnectorTokensConnectEnvironment?>
    {
        /// <inheritdoc />
        public override global::Vercel.ImportConnectorTokensConnectEnvironment? Read(
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
                        return global::Vercel.ImportConnectorTokensConnectEnvironmentExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.ImportConnectorTokensConnectEnvironment)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.ImportConnectorTokensConnectEnvironment?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.ImportConnectorTokensConnectEnvironment? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.ImportConnectorTokensConnectEnvironmentExtensions.ToValueString(value.Value));
            }
        }
    }
}
