
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuyCreditsResponseVariant3OrbSubscriptionIntentOrbUpdateVariant3Mode
    {
        /// <summary>
        /// 
        /// </summary>
        Async,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuyCreditsResponseVariant3OrbSubscriptionIntentOrbUpdateVariant3ModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuyCreditsResponseVariant3OrbSubscriptionIntentOrbUpdateVariant3Mode value)
        {
            return value switch
            {
                BuyCreditsResponseVariant3OrbSubscriptionIntentOrbUpdateVariant3Mode.Async => "async",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuyCreditsResponseVariant3OrbSubscriptionIntentOrbUpdateVariant3Mode? ToEnum(string value)
        {
            return value switch
            {
                "async" => BuyCreditsResponseVariant3OrbSubscriptionIntentOrbUpdateVariant3Mode.Async,
                _ => null,
            };
        }
    }
}