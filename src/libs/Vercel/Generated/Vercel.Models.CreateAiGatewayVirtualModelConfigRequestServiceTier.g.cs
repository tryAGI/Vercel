
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The service tier for providers that support it. `@default` ignores the value from the inference request.
    /// </summary>
    public enum CreateAiGatewayVirtualModelConfigRequestServiceTier
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
    public static class CreateAiGatewayVirtualModelConfigRequestServiceTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAiGatewayVirtualModelConfigRequestServiceTier value)
        {
            return value switch
            {
                CreateAiGatewayVirtualModelConfigRequestServiceTier.x_default => "@default",
                CreateAiGatewayVirtualModelConfigRequestServiceTier.Fast => "fast",
                CreateAiGatewayVirtualModelConfigRequestServiceTier.Flex => "flex",
                CreateAiGatewayVirtualModelConfigRequestServiceTier.Priority => "priority",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAiGatewayVirtualModelConfigRequestServiceTier? ToEnum(string value)
        {
            return value switch
            {
                "@default" => CreateAiGatewayVirtualModelConfigRequestServiceTier.x_default,
                "fast" => CreateAiGatewayVirtualModelConfigRequestServiceTier.Fast,
                "flex" => CreateAiGatewayVirtualModelConfigRequestServiceTier.Flex,
                "priority" => CreateAiGatewayVirtualModelConfigRequestServiceTier.Priority,
                _ => null,
            };
        }
    }
}