
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Rank eligible providers by an attribute. `@default` ignores the value from the inference request.
    /// </summary>
    public enum CreateAiGatewayVirtualModelConfigRequestSort
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
    public static class CreateAiGatewayVirtualModelConfigRequestSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAiGatewayVirtualModelConfigRequestSort value)
        {
            return value switch
            {
                CreateAiGatewayVirtualModelConfigRequestSort.x_default => "@default",
                CreateAiGatewayVirtualModelConfigRequestSort.Cost => "cost",
                CreateAiGatewayVirtualModelConfigRequestSort.Latency => "latency",
                CreateAiGatewayVirtualModelConfigRequestSort.Price => "price",
                CreateAiGatewayVirtualModelConfigRequestSort.Throughput => "throughput",
                CreateAiGatewayVirtualModelConfigRequestSort.Tps => "tps",
                CreateAiGatewayVirtualModelConfigRequestSort.Ttft => "ttft",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAiGatewayVirtualModelConfigRequestSort? ToEnum(string value)
        {
            return value switch
            {
                "@default" => CreateAiGatewayVirtualModelConfigRequestSort.x_default,
                "cost" => CreateAiGatewayVirtualModelConfigRequestSort.Cost,
                "latency" => CreateAiGatewayVirtualModelConfigRequestSort.Latency,
                "price" => CreateAiGatewayVirtualModelConfigRequestSort.Price,
                "throughput" => CreateAiGatewayVirtualModelConfigRequestSort.Throughput,
                "tps" => CreateAiGatewayVirtualModelConfigRequestSort.Tps,
                "ttft" => CreateAiGatewayVirtualModelConfigRequestSort.Ttft,
                _ => null,
            };
        }
    }
}