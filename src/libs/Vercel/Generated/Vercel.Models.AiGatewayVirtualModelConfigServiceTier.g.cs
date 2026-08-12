
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Service tier for providers that support it.
    /// </summary>
    public enum AiGatewayVirtualModelConfigServiceTier
    {
        /// <summary>
        /// 
        /// </summary>
        Fast,
        /// <summary>
        /// 
        /// </summary>
        Flex,
        /// <summary>
        /// 
        /// </summary>
        Priority,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AiGatewayVirtualModelConfigServiceTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiGatewayVirtualModelConfigServiceTier value)
        {
            return value switch
            {
                AiGatewayVirtualModelConfigServiceTier.Fast => "fast",
                AiGatewayVirtualModelConfigServiceTier.Flex => "flex",
                AiGatewayVirtualModelConfigServiceTier.Priority => "priority",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiGatewayVirtualModelConfigServiceTier? ToEnum(string value)
        {
            return value switch
            {
                "fast" => AiGatewayVirtualModelConfigServiceTier.Fast,
                "flex" => AiGatewayVirtualModelConfigServiceTier.Flex,
                "priority" => AiGatewayVirtualModelConfigServiceTier.Priority,
                _ => null,
            };
        }
    }
}