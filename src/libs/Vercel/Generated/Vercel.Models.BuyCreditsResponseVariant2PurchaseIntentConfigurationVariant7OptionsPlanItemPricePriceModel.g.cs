
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsPlanItemPricePriceModel
    {
        /// <summary>
        ///
        /// </summary>
        Unit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsPlanItemPricePriceModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsPlanItemPricePriceModel value)
        {
            return value switch
            {
                BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsPlanItemPricePriceModel.Unit => "unit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsPlanItemPricePriceModel? ToEnum(string value)
        {
            return value switch
            {
                "unit" => BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsPlanItemPricePriceModel.Unit,
                _ => null,
            };
        }
    }
}