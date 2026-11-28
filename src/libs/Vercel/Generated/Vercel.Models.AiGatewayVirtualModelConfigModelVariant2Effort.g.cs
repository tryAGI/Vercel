
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AiGatewayVirtualModelConfigModelVariant2Effort
    {
        /// <summary>
        ///
        /// </summary>
        High,
        /// <summary>
        ///
        /// </summary>
        Low,
        /// <summary>
        ///
        /// </summary>
        Medium,
        /// <summary>
        ///
        /// </summary>
        Minimal,
        /// <summary>
        ///
        /// </summary>
        None,
        /// <summary>
        ///
        /// </summary>
        Xhigh,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AiGatewayVirtualModelConfigModelVariant2EffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiGatewayVirtualModelConfigModelVariant2Effort value)
        {
            return value switch
            {
                AiGatewayVirtualModelConfigModelVariant2Effort.High => "high",
                AiGatewayVirtualModelConfigModelVariant2Effort.Low => "low",
                AiGatewayVirtualModelConfigModelVariant2Effort.Medium => "medium",
                AiGatewayVirtualModelConfigModelVariant2Effort.Minimal => "minimal",
                AiGatewayVirtualModelConfigModelVariant2Effort.None => "none",
                AiGatewayVirtualModelConfigModelVariant2Effort.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiGatewayVirtualModelConfigModelVariant2Effort? ToEnum(string value)
        {
            return value switch
            {
                "high" => AiGatewayVirtualModelConfigModelVariant2Effort.High,
                "low" => AiGatewayVirtualModelConfigModelVariant2Effort.Low,
                "medium" => AiGatewayVirtualModelConfigModelVariant2Effort.Medium,
                "minimal" => AiGatewayVirtualModelConfigModelVariant2Effort.Minimal,
                "none" => AiGatewayVirtualModelConfigModelVariant2Effort.None,
                "xhigh" => AiGatewayVirtualModelConfigModelVariant2Effort.Xhigh,
                _ => null,
            };
        }
    }
}