#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class ImportConnectorTokensResponseTokenSubjectVariant2TypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.ImportConnectorTokensResponseTokenSubjectVariant2Type?>
    {
        /// <inheritdoc />
        public override global::Vercel.ImportConnectorTokensResponseTokenSubjectVariant2Type? Read(
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
                        return global::Vercel.ImportConnectorTokensResponseTokenSubjectVariant2TypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.ImportConnectorTokensResponseTokenSubjectVariant2Type)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.ImportConnectorTokensResponseTokenSubjectVariant2Type?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.ImportConnectorTokensResponseTokenSubjectVariant2Type? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.ImportConnectorTokensResponseTokenSubjectVariant2TypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
