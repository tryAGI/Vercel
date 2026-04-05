
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant2OutputChangedResourceVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        SetPlanItemQuantity,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant2OutputChangedResourceVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant2OutputChangedResourceVariant1Type value)
        {
            return value switch
            {
                BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant2OutputChangedResourceVariant1Type.SetPlanItemQuantity => "set_plan_item_quantity",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant2OutputChangedResourceVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "set_plan_item_quantity" => BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant2OutputChangedResourceVariant1Type.SetPlanItemQuantity,
                _ => null,
            };
        }
    }
}