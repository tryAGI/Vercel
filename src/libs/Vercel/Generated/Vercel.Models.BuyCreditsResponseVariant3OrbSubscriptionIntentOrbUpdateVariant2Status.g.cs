
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum BuyCreditsResponseVariant3OrbSubscriptionIntentOrbUpdateVariant2Status
    {
        /// <summary>
        ///
        /// </summary>
        Canceled,
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        Pending,
        /// <summary>
        ///
        /// </summary>
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuyCreditsResponseVariant3OrbSubscriptionIntentOrbUpdateVariant2StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuyCreditsResponseVariant3OrbSubscriptionIntentOrbUpdateVariant2Status value)
        {
            return value switch
            {
                BuyCreditsResponseVariant3OrbSubscriptionIntentOrbUpdateVariant2Status.Canceled => "canceled",
                BuyCreditsResponseVariant3OrbSubscriptionIntentOrbUpdateVariant2Status.Failed => "failed",
                BuyCreditsResponseVariant3OrbSubscriptionIntentOrbUpdateVariant2Status.Pending => "pending",
                BuyCreditsResponseVariant3OrbSubscriptionIntentOrbUpdateVariant2Status.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuyCreditsResponseVariant3OrbSubscriptionIntentOrbUpdateVariant2Status? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => BuyCreditsResponseVariant3OrbSubscriptionIntentOrbUpdateVariant2Status.Canceled,
                "failed" => BuyCreditsResponseVariant3OrbSubscriptionIntentOrbUpdateVariant2Status.Failed,
                "pending" => BuyCreditsResponseVariant3OrbSubscriptionIntentOrbUpdateVariant2Status.Pending,
                "running" => BuyCreditsResponseVariant3OrbSubscriptionIntentOrbUpdateVariant2Status.Running,
                _ => null,
            };
        }
    }
}