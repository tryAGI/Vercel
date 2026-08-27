
#nullable enable

namespace Vercel
{
    /// <summary>
    /// When the subscription change should take effect.
    /// </summary>
    public enum BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant1OutputEffectiveBehavior
    {
        /// <summary>
        ///
        /// </summary>
        EndOfTerm,
        /// <summary>
        ///
        /// </summary>
        Immediate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant1OutputEffectiveBehaviorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant1OutputEffectiveBehavior value)
        {
            return value switch
            {
                BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant1OutputEffectiveBehavior.EndOfTerm => "end_of_term",
                BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant1OutputEffectiveBehavior.Immediate => "immediate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant1OutputEffectiveBehavior? ToEnum(string value)
        {
            return value switch
            {
                "end_of_term" => BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant1OutputEffectiveBehavior.EndOfTerm,
                "immediate" => BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant1OutputEffectiveBehavior.Immediate,
                _ => null,
            };
        }
    }
}