
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Rank eligible providers by an attribute. `@default` ignores the value from the inference request. `null` removes the stored value.
    /// </summary>
    public enum UpdateAiGatewayVirtualModelConfigBySlugRequestSort
    {
        /// <summary>
        ///
        /// </summary>
        x_default,
        /// <summary>
        ///
        /// </summary>
        Cost,
        /// <summary>
        ///
        /// </summary>
        Latency,
        /// <summary>
        ///
        /// </summary>
        Price,
        /// <summary>
        ///
        /// </summary>
        Throughput,
        /// <summary>
        ///
        /// </summary>
        Tps,
        /// <summary>
        ///
        /// </summary>
        Ttft,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateAiGatewayVirtualModelConfigBySlugRequestSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAiGatewayVirtualModelConfigBySlugRequestSort value)
        {
            return value switch
            {
                UpdateAiGatewayVirtualModelConfigBySlugRequestSort.x_default => "@default",
                UpdateAiGatewayVirtualModelConfigBySlugRequestSort.Cost => "cost",
                UpdateAiGatewayVirtualModelConfigBySlugRequestSort.Latency => "latency",
                UpdateAiGatewayVirtualModelConfigBySlugRequestSort.Price => "price",
                UpdateAiGatewayVirtualModelConfigBySlugRequestSort.Throughput => "throughput",
                UpdateAiGatewayVirtualModelConfigBySlugRequestSort.Tps => "tps",
                UpdateAiGatewayVirtualModelConfigBySlugRequestSort.Ttft => "ttft",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAiGatewayVirtualModelConfigBySlugRequestSort? ToEnum(string value)
        {
            return value switch
            {
                "@default" => UpdateAiGatewayVirtualModelConfigBySlugRequestSort.x_default,
                "cost" => UpdateAiGatewayVirtualModelConfigBySlugRequestSort.Cost,
                "latency" => UpdateAiGatewayVirtualModelConfigBySlugRequestSort.Latency,
                "price" => UpdateAiGatewayVirtualModelConfigBySlugRequestSort.Price,
                "throughput" => UpdateAiGatewayVirtualModelConfigBySlugRequestSort.Throughput,
                "tps" => UpdateAiGatewayVirtualModelConfigBySlugRequestSort.Tps,
                "ttft" => UpdateAiGatewayVirtualModelConfigBySlugRequestSort.Ttft,
                _ => null,
            };
        }
    }
}