
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The service tier for providers that support it. `@default` ignores the value from the inference request. `null` removes the stored value.
    /// </summary>
    public enum UpdateAiGatewayVirtualModelConfigRequestServiceTier
    {
        /// <summary>
        ///
        /// </summary>
        x_default,
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
    public static class UpdateAiGatewayVirtualModelConfigRequestServiceTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAiGatewayVirtualModelConfigRequestServiceTier value)
        {
            return value switch
            {
                UpdateAiGatewayVirtualModelConfigRequestServiceTier.x_default => "@default",
                UpdateAiGatewayVirtualModelConfigRequestServiceTier.Fast => "fast",
                UpdateAiGatewayVirtualModelConfigRequestServiceTier.Flex => "flex",
                UpdateAiGatewayVirtualModelConfigRequestServiceTier.Priority => "priority",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAiGatewayVirtualModelConfigRequestServiceTier? ToEnum(string value)
        {
            return value switch
            {
                "@default" => UpdateAiGatewayVirtualModelConfigRequestServiceTier.x_default,
                "fast" => UpdateAiGatewayVirtualModelConfigRequestServiceTier.Fast,
                "flex" => UpdateAiGatewayVirtualModelConfigRequestServiceTier.Flex,
                "priority" => UpdateAiGatewayVirtualModelConfigRequestServiceTier.Priority,
                _ => null,
            };
        }
    }
}