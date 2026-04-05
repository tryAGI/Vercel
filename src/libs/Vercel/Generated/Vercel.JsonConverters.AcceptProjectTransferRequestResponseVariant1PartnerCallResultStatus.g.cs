#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class AcceptProjectTransferRequestResponseVariant1PartnerCallResultStatusJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.AcceptProjectTransferRequestResponseVariant1PartnerCallResultStatus>
    {
        /// <inheritdoc />
        public override global::Vercel.AcceptProjectTransferRequestResponseVariant1PartnerCallResultStatus Read(
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
                        return global::Vercel.AcceptProjectTransferRequestResponseVariant1PartnerCallResultStatusExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.AcceptProjectTransferRequestResponseVariant1PartnerCallResultStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.AcceptProjectTransferRequestResponseVariant1PartnerCallResultStatus);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.AcceptProjectTransferRequestResponseVariant1PartnerCallResultStatus value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.AcceptProjectTransferRequestResponseVariant1PartnerCallResultStatusExtensions.ToValueString(value));
        }
    }
}
