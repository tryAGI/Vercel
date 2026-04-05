
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The status of the Orb subscription intent.
    /// </summary>
    public enum BuyCreditsResponseVariant3OrbSubscriptionIntentStatus
    {
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
        Succeeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuyCreditsResponseVariant3OrbSubscriptionIntentStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuyCreditsResponseVariant3OrbSubscriptionIntentStatus value)
        {
            return value switch
            {
                BuyCreditsResponseVariant3OrbSubscriptionIntentStatus.Failed => "failed",
                BuyCreditsResponseVariant3OrbSubscriptionIntentStatus.Pending => "pending",
                BuyCreditsResponseVariant3OrbSubscriptionIntentStatus.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuyCreditsResponseVariant3OrbSubscriptionIntentStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => BuyCreditsResponseVariant3OrbSubscriptionIntentStatus.Failed,
                "pending" => BuyCreditsResponseVariant3OrbSubscriptionIntentStatus.Pending,
                "succeeded" => BuyCreditsResponseVariant3OrbSubscriptionIntentStatus.Succeeded,
                _ => null,
            };
        }
    }
}