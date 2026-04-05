
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant3OutputChangedResourceVariant3Type
    {
        /// <summary>
        /// 
        /// </summary>
        DecreasePlanItemQuantity,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant3OutputChangedResourceVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant3OutputChangedResourceVariant3Type value)
        {
            return value switch
            {
                BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant3OutputChangedResourceVariant3Type.DecreasePlanItemQuantity => "decrease_plan_item_quantity",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant3OutputChangedResourceVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "decrease_plan_item_quantity" => BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant3OutputChangedResourceVariant3Type.DecreasePlanItemQuantity,
                _ => null,
            };
        }
    }
}