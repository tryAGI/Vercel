
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuyCreditsResponseVariant3OrbSubscriptionIntentOrbUpdateVariant3Status
    {
        /// <summary>
        /// 
        /// </summary>
        Succeeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuyCreditsResponseVariant3OrbSubscriptionIntentOrbUpdateVariant3StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuyCreditsResponseVariant3OrbSubscriptionIntentOrbUpdateVariant3Status value)
        {
            return value switch
            {
                BuyCreditsResponseVariant3OrbSubscriptionIntentOrbUpdateVariant3Status.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuyCreditsResponseVariant3OrbSubscriptionIntentOrbUpdateVariant3Status? ToEnum(string value)
        {
            return value switch
            {
                "succeeded" => BuyCreditsResponseVariant3OrbSubscriptionIntentOrbUpdateVariant3Status.Succeeded,
                _ => null,
            };
        }
    }
}