
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The service tier for providers that support it. `@default` ignores the value from the inference request. `null` removes the stored value.
    /// </summary>
    public enum UpdateAiGatewayVirtualModelConfigBySlugRequestServiceTier
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
    public static class UpdateAiGatewayVirtualModelConfigBySlugRequestServiceTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAiGatewayVirtualModelConfigBySlugRequestServiceTier value)
        {
            return value switch
            {
                UpdateAiGatewayVirtualModelConfigBySlugRequestServiceTier.x_default => "@default",
                UpdateAiGatewayVirtualModelConfigBySlugRequestServiceTier.Fast => "fast",
                UpdateAiGatewayVirtualModelConfigBySlugRequestServiceTier.Flex => "flex",
                UpdateAiGatewayVirtualModelConfigBySlugRequestServiceTier.Priority => "priority",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAiGatewayVirtualModelConfigBySlugRequestServiceTier? ToEnum(string value)
        {
            return value switch
            {
                "@default" => UpdateAiGatewayVirtualModelConfigBySlugRequestServiceTier.x_default,
                "fast" => UpdateAiGatewayVirtualModelConfigBySlugRequestServiceTier.Fast,
                "flex" => UpdateAiGatewayVirtualModelConfigBySlugRequestServiceTier.Flex,
                "priority" => UpdateAiGatewayVirtualModelConfigBySlugRequestServiceTier.Priority,
                _ => null,
            };
        }
    }
}