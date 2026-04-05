#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReasonJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason>
    {
        /// <inheritdoc />
        public override global::Vercel.UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason Read(
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
                        return global::Vercel.UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReasonExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReasonExtensions.ToValueString(value));
        }
    }
}
