
#nullable enable

namespace Vercel
{
    /// <summary>
    /// For kind=router: how to order candidates. Absent means declared order.
    /// </summary>
    public enum AiGatewayVirtualModelConfigSelector
    {
        /// <summary>
        ///
        /// </summary>
        Cost,
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
    public static class AiGatewayVirtualModelConfigSelectorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiGatewayVirtualModelConfigSelector value)
        {
            return value switch
            {
                AiGatewayVirtualModelConfigSelector.Cost => "cost",
                AiGatewayVirtualModelConfigSelector.Tps => "tps",
                AiGatewayVirtualModelConfigSelector.Ttft => "ttft",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiGatewayVirtualModelConfigSelector? ToEnum(string value)
        {
            return value switch
            {
                "cost" => AiGatewayVirtualModelConfigSelector.Cost,
                "tps" => AiGatewayVirtualModelConfigSelector.Tps,
                "ttft" => AiGatewayVirtualModelConfigSelector.Ttft,
                _ => null,
            };
        }
    }
}