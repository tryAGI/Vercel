
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The source used as the authoritative price for this intent.
    /// </summary>
    public enum BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant2OutputPricingSource
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
    public static class BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant2OutputPricingSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant2OutputPricingSource value)
        {
            return value switch
            {
                BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant2OutputPricingSource.Copper => "copper",
                BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant2OutputPricingSource.Orb => "orb",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant2OutputPricingSource? ToEnum(string value)
        {
            return value switch
            {
                "copper" => BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant2OutputPricingSource.Copper,
                "orb" => BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant2OutputPricingSource.Orb,
                _ => null,
            };
        }
    }
}