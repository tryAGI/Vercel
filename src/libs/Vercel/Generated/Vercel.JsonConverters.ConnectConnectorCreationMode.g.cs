#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class ConnectConnectorCreationModeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.ConnectConnectorCreationMode>
    {
        /// <inheritdoc />
        public override global::Vercel.ConnectConnectorCreationMode Read(
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
                        return global::Vercel.ConnectConnectorCreationModeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.ConnectConnectorCreationMode)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.ConnectConnectorCreationMode);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.ConnectConnectorCreationMode value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.ConnectConnectorCreationModeExtensions.ToValueString(value));
        }
    }
}
