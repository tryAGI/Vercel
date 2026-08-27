
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum BuyCreditsResponseVariant3OrbSubscriptionIntentOrbUpdateVariant1Mode
    {
        /// <summary>
        ///
        /// </summary>
        Sync,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuyCreditsResponseVariant3OrbSubscriptionIntentOrbUpdateVariant1ModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuyCreditsResponseVariant3OrbSubscriptionIntentOrbUpdateVariant1Mode value)
        {
            return value switch
            {
                BuyCreditsResponseVariant3OrbSubscriptionIntentOrbUpdateVariant1Mode.Sync => "sync",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuyCreditsResponseVariant3OrbSubscriptionIntentOrbUpdateVariant1Mode? ToEnum(string value)
        {
            return value switch
            {
                "sync" => BuyCreditsResponseVariant3OrbSubscriptionIntentOrbUpdateVariant1Mode.Sync,
                _ => null,
            };
        }
    }
}