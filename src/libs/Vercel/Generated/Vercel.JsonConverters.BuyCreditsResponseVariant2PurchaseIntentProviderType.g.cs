#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class BuyCreditsResponseVariant2PurchaseIntentProviderTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.BuyCreditsResponseVariant2PurchaseIntentProviderType>
    {
        /// <inheritdoc />
        public override global::Vercel.BuyCreditsResponseVariant2PurchaseIntentProviderType Read(
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
                        return global::Vercel.BuyCreditsResponseVariant2PurchaseIntentProviderTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.BuyCreditsResponseVariant2PurchaseIntentProviderType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.BuyCreditsResponseVariant2PurchaseIntentProviderType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.BuyCreditsResponseVariant2PurchaseIntentProviderType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.BuyCreditsResponseVariant2PurchaseIntentProviderTypeExtensions.ToValueString(value));
        }
    }
}
