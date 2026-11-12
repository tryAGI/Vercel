#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsVariant1PlanItemPricePriceModelNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsVariant1PlanItemPricePriceModel?>
    {
        /// <inheritdoc />
        public override global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsVariant1PlanItemPricePriceModel? Read(
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
                        return global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsVariant1PlanItemPricePriceModelExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsVariant1PlanItemPricePriceModel)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsVariant1PlanItemPricePriceModel?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsVariant1PlanItemPricePriceModel? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsVariant1PlanItemPricePriceModelExtensions.ToValueString(value.Value));
            }
        }
    }
}
