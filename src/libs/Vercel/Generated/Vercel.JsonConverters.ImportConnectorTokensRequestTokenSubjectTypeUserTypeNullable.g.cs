#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class ImportConnectorTokensRequestTokenSubjectTypeUserTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.ImportConnectorTokensRequestTokenSubjectTypeUserType?>
    {
        /// <inheritdoc />
        public override global::Vercel.ImportConnectorTokensRequestTokenSubjectTypeUserType? Read(
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
                        return global::Vercel.ImportConnectorTokensRequestTokenSubjectTypeUserTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.ImportConnectorTokensRequestTokenSubjectTypeUserType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.ImportConnectorTokensRequestTokenSubjectTypeUserType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.ImportConnectorTokensRequestTokenSubjectTypeUserType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.ImportConnectorTokensRequestTokenSubjectTypeUserTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
