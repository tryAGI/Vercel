
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Rank eligible providers by an attribute. `@default` ignores the value from the inference request. `null` removes the stored value.
    /// </summary>
    public enum UpdateAiGatewayVirtualModelConfigRequestSort
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
    public static class UpdateAiGatewayVirtualModelConfigRequestSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAiGatewayVirtualModelConfigRequestSort value)
        {
            return value switch
            {
                UpdateAiGatewayVirtualModelConfigRequestSort.x_default => "@default",
                UpdateAiGatewayVirtualModelConfigRequestSort.Cost => "cost",
                UpdateAiGatewayVirtualModelConfigRequestSort.Latency => "latency",
                UpdateAiGatewayVirtualModelConfigRequestSort.Price => "price",
                UpdateAiGatewayVirtualModelConfigRequestSort.Throughput => "throughput",
                UpdateAiGatewayVirtualModelConfigRequestSort.Tps => "tps",
                UpdateAiGatewayVirtualModelConfigRequestSort.Ttft => "ttft",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAiGatewayVirtualModelConfigRequestSort? ToEnum(string value)
        {
            return value switch
            {
                "@default" => UpdateAiGatewayVirtualModelConfigRequestSort.x_default,
                "cost" => UpdateAiGatewayVirtualModelConfigRequestSort.Cost,
                "latency" => UpdateAiGatewayVirtualModelConfigRequestSort.Latency,
                "price" => UpdateAiGatewayVirtualModelConfigRequestSort.Price,
                "throughput" => UpdateAiGatewayVirtualModelConfigRequestSort.Throughput,
                "tps" => UpdateAiGatewayVirtualModelConfigRequestSort.Tps,
                "ttft" => UpdateAiGatewayVirtualModelConfigRequestSort.Ttft,
                _ => null,
            };
        }
    }
}