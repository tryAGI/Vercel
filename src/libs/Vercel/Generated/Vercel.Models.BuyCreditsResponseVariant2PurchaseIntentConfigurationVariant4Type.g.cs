
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant4Type
    {
        /// <summary>
        /// 
        /// </summary>
        OrbPriceInterval,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant4Type value)
        {
            return value switch
            {
                BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant4Type.OrbPriceInterval => "orb_price_interval",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "orb_price_interval" => BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant4Type.OrbPriceInterval,
                _ => null,
            };
        }
    }
}