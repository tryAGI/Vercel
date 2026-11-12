
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsVariant1PlanItemPricePriceModel
    {
        /// <summary>
        ///
        /// </summary>
        Unit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsVariant1PlanItemPricePriceModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsVariant1PlanItemPricePriceModel value)
        {
            return value switch
            {
                BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsVariant1PlanItemPricePriceModel.Unit => "unit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsVariant1PlanItemPricePriceModel? ToEnum(string value)
        {
            return value switch
            {
                "unit" => BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsVariant1PlanItemPricePriceModel.Unit,
                _ => null,
            };
        }
    }
}