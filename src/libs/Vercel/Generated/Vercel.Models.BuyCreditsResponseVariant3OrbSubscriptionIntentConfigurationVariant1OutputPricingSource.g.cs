
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The source used as the authoritative price for this intent.
    /// </summary>
    public enum BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant1OutputPricingSource
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
    public static class BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant1OutputPricingSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant1OutputPricingSource value)
        {
            return value switch
            {
                BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant1OutputPricingSource.Copper => "copper",
                BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant1OutputPricingSource.Orb => "orb",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant1OutputPricingSource? ToEnum(string value)
        {
            return value switch
            {
                "copper" => BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant1OutputPricingSource.Copper,
                "orb" => BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant1OutputPricingSource.Orb,
                _ => null,
            };
        }
    }
}