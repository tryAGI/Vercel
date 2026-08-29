
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The source used as the authoritative price for this intent.
    /// </summary>
    public enum BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant3OutputPricingSource
    {
        /// <summary>
        ///
        /// </summary>
        Copper,
        /// <summary>
        ///
        /// </summary>
        Orb,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant3OutputPricingSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant3OutputPricingSource value)
        {
            return value switch
            {
                BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant3OutputPricingSource.Copper => "copper",
                BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant3OutputPricingSource.Orb => "orb",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant3OutputPricingSource? ToEnum(string value)
        {
            return value switch
            {
                "copper" => BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant3OutputPricingSource.Copper,
                "orb" => BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant3OutputPricingSource.Orb,
                _ => null,
            };
        }
    }
}