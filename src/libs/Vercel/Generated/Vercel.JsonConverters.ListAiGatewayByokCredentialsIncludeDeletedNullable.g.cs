#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class ListAiGatewayByokCredentialsIncludeDeletedNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.ListAiGatewayByokCredentialsIncludeDeleted?>
    {
        /// <inheritdoc />
        public override global::Vercel.ListAiGatewayByokCredentialsIncludeDeleted? Read(
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
                        return global::Vercel.ListAiGatewayByokCredentialsIncludeDeletedExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.ListAiGatewayByokCredentialsIncludeDeleted)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.ListAiGatewayByokCredentialsIncludeDeleted?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.ListAiGatewayByokCredentialsIncludeDeleted? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.ListAiGatewayByokCredentialsIncludeDeletedExtensions.ToValueString(value.Value));
            }
        }
    }
}
