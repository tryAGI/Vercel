
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The status of the Purchase Intent.
    /// </summary>
    public enum BuyCreditsResponseVariant2PurchaseIntentStatus
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
    public static class BuyCreditsResponseVariant2PurchaseIntentStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuyCreditsResponseVariant2PurchaseIntentStatus value)
        {
            return value switch
            {
                BuyCreditsResponseVariant2PurchaseIntentStatus.Failed => "failed",
                BuyCreditsResponseVariant2PurchaseIntentStatus.Pending => "pending",
                BuyCreditsResponseVariant2PurchaseIntentStatus.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuyCreditsResponseVariant2PurchaseIntentStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => BuyCreditsResponseVariant2PurchaseIntentStatus.Failed,
                "pending" => BuyCreditsResponseVariant2PurchaseIntentStatus.Pending,
                "succeeded" => BuyCreditsResponseVariant2PurchaseIntentStatus.Succeeded,
                _ => null,
            };
        }
    }
}