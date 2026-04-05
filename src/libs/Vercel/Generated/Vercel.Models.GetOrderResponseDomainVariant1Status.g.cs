
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetOrderResponseDomainVariant1Status
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
    public static class GetOrderResponseDomainVariant1StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrderResponseDomainVariant1Status value)
        {
            return value switch
            {
                GetOrderResponseDomainVariant1Status.Completed => "completed",
                GetOrderResponseDomainVariant1Status.Failed => "failed",
                GetOrderResponseDomainVariant1Status.Pending => "pending",
                GetOrderResponseDomainVariant1Status.RefundFailed => "refund-failed",
                GetOrderResponseDomainVariant1Status.Refunded => "refunded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrderResponseDomainVariant1Status? ToEnum(string value)
        {
            return value switch
            {
                "completed" => GetOrderResponseDomainVariant1Status.Completed,
                "failed" => GetOrderResponseDomainVariant1Status.Failed,
                "pending" => GetOrderResponseDomainVariant1Status.Pending,
                "refund-failed" => GetOrderResponseDomainVariant1Status.RefundFailed,
                "refunded" => GetOrderResponseDomainVariant1Status.Refunded,
                _ => null,
            };
        }
    }
}