
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant5Type
    {
        /// <summary>
        /// 
        /// </summary>
        OrbSubscription,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant5TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant5Type value)
        {
            return value switch
            {
                BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant5Type.OrbSubscription => "orb_subscription",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant5Type? ToEnum(string value)
        {
            return value switch
            {
                "orb_subscription" => BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant5Type.OrbSubscription,
                _ => null,
            };
        }
    }
}