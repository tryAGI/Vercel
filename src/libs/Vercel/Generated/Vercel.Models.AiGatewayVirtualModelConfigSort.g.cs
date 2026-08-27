
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Rank eligible providers by an attribute.
    /// </summary>
    public enum AiGatewayVirtualModelConfigSort
    {
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
    public static class AiGatewayVirtualModelConfigSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiGatewayVirtualModelConfigSort value)
        {
            return value switch
            {
                AiGatewayVirtualModelConfigSort.Cost => "cost",
                AiGatewayVirtualModelConfigSort.Latency => "latency",
                AiGatewayVirtualModelConfigSort.Price => "price",
                AiGatewayVirtualModelConfigSort.Throughput => "throughput",
                AiGatewayVirtualModelConfigSort.Tps => "tps",
                AiGatewayVirtualModelConfigSort.Ttft => "ttft",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiGatewayVirtualModelConfigSort? ToEnum(string value)
        {
            return value switch
            {
                "cost" => AiGatewayVirtualModelConfigSort.Cost,
                "latency" => AiGatewayVirtualModelConfigSort.Latency,
                "price" => AiGatewayVirtualModelConfigSort.Price,
                "throughput" => AiGatewayVirtualModelConfigSort.Throughput,
                "tps" => AiGatewayVirtualModelConfigSort.Tps,
                "ttft" => AiGatewayVirtualModelConfigSort.Ttft,
                _ => null,
            };
        }
    }
}