
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant5Type
    {
        /// <summary>
        ///
        /// </summary>
        AdjustPlanItemQuantity,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant5TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant5Type value)
        {
            return value switch
            {
                BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant5Type.AdjustPlanItemQuantity => "adjust_plan_item_quantity",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant5Type? ToEnum(string value)
        {
            return value switch
            {
                "adjust_plan_item_quantity" => BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant5Type.AdjustPlanItemQuantity,
                _ => null,
            };
        }
    }
}