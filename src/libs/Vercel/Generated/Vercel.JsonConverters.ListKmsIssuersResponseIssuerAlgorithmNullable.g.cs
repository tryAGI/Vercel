#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class ListKmsIssuersResponseIssuerAlgorithmNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.ListKmsIssuersResponseIssuerAlgorithm?>
    {
        /// <inheritdoc />
        public override global::Vercel.ListKmsIssuersResponseIssuerAlgorithm? Read(
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
                        return global::Vercel.ListKmsIssuersResponseIssuerAlgorithmExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.ListKmsIssuersResponseIssuerAlgorithm)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.ListKmsIssuersResponseIssuerAlgorithm?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.ListKmsIssuersResponseIssuerAlgorithm? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.ListKmsIssuersResponseIssuerAlgorithmExtensions.ToValueString(value.Value));
            }
        }
    }
}
