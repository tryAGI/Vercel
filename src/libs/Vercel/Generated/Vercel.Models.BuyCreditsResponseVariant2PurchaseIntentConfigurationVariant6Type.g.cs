
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant6Type
    {
        /// <summary>
        /// 
        /// </summary>
        OrbSubscriptionIntent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant6TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant6Type value)
        {
            return value switch
            {
                BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant6Type.OrbSubscriptionIntent => "orb_subscription_intent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant6Type? ToEnum(string value)
        {
            return value switch
            {
                "orb_subscription_intent" => BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant6Type.OrbSubscriptionIntent,
                _ => null,
            };
        }
    }
}