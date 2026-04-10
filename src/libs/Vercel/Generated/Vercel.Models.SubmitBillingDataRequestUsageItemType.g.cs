
#nullable enable

namespace Vercel
{
    /// <summary>
    ///               Type of the metric.<br/>
    ///               - total: measured total value, such as Database size<br/>
    ///               - interval: usage during the period, such as i/o or number of queries.<br/>
    ///               - rate: rate of usage, such as queries per second.<br/>
    ///             
    /// </summary>
    public enum SubmitBillingDataRequestUsageItemType
    {
        /// <summary>
        /// usage during the period, such as i/o or number of queries.
        /// </summary>
        Interval,
        /// <summary>
        /// rate of usage, such as queries per second.
        /// </summary>
        Rate,
        /// <summary>
        /// measured total value, such as Database size
        /// </summary>
        Total,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubmitBillingDataRequestUsageItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubmitBillingDataRequestUsageItemType value)
        {
            return value switch
            {
                SubmitBillingDataRequestUsageItemType.Interval => "interval",
                SubmitBillingDataRequestUsageItemType.Rate => "rate",
                SubmitBillingDataRequestUsageItemType.Total => "total",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubmitBillingDataRequestUsageItemType? ToEnum(string value)
        {
            return value switch
            {
                "interval" => SubmitBillingDataRequestUsageItemType.Interval,
                "rate" => SubmitBillingDataRequestUsageItemType.Rate,
                "total" => SubmitBillingDataRequestUsageItemType.Total,
                _ => null,
            };
        }
    }
}