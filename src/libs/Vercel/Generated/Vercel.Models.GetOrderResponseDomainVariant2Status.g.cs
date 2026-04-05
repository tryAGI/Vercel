
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetOrderResponseDomainVariant2Status
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
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
        RefundFailed,
        /// <summary>
        /// 
        /// </summary>
        Refunded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetOrderResponseDomainVariant2StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrderResponseDomainVariant2Status value)
        {
            return value switch
            {
                GetOrderResponseDomainVariant2Status.Completed => "completed",
                GetOrderResponseDomainVariant2Status.Failed => "failed",
                GetOrderResponseDomainVariant2Status.Pending => "pending",
                GetOrderResponseDomainVariant2Status.RefundFailed => "refund-failed",
                GetOrderResponseDomainVariant2Status.Refunded => "refunded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrderResponseDomainVariant2Status? ToEnum(string value)
        {
            return value switch
            {
                "completed" => GetOrderResponseDomainVariant2Status.Completed,
                "failed" => GetOrderResponseDomainVariant2Status.Failed,
                "pending" => GetOrderResponseDomainVariant2Status.Pending,
                "refund-failed" => GetOrderResponseDomainVariant2Status.RefundFailed,
                "refunded" => GetOrderResponseDomainVariant2Status.Refunded,
                _ => null,
            };
        }
    }
}