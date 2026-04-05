
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetOrderResponseDomainVariant3Status
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
    public static class GetOrderResponseDomainVariant3StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrderResponseDomainVariant3Status value)
        {
            return value switch
            {
                GetOrderResponseDomainVariant3Status.Completed => "completed",
                GetOrderResponseDomainVariant3Status.Failed => "failed",
                GetOrderResponseDomainVariant3Status.Pending => "pending",
                GetOrderResponseDomainVariant3Status.RefundFailed => "refund-failed",
                GetOrderResponseDomainVariant3Status.Refunded => "refunded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrderResponseDomainVariant3Status? ToEnum(string value)
        {
            return value switch
            {
                "completed" => GetOrderResponseDomainVariant3Status.Completed,
                "failed" => GetOrderResponseDomainVariant3Status.Failed,
                "pending" => GetOrderResponseDomainVariant3Status.Pending,
                "refund-failed" => GetOrderResponseDomainVariant3Status.RefundFailed,
                "refunded" => GetOrderResponseDomainVariant3Status.Refunded,
                _ => null,
            };
        }
    }
}