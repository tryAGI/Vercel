#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class RevokeKmsSigningKeyResponsePolicieVariant2KindJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.RevokeKmsSigningKeyResponsePolicieVariant2Kind>
    {
        /// <inheritdoc />
        public override global::Vercel.RevokeKmsSigningKeyResponsePolicieVariant2Kind Read(
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
                        return global::Vercel.RevokeKmsSigningKeyResponsePolicieVariant2KindExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.RevokeKmsSigningKeyResponsePolicieVariant2Kind)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.RevokeKmsSigningKeyResponsePolicieVariant2Kind);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.RevokeKmsSigningKeyResponsePolicieVariant2Kind value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.RevokeKmsSigningKeyResponsePolicieVariant2KindExtensions.ToValueString(value));
        }
    }
}
