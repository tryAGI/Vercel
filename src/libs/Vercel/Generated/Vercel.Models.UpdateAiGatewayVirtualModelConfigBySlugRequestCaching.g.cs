
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Use caching if available. `@default` ignores the value from the inference request. `null` removes the stored value.
    /// </summary>
    public enum UpdateAiGatewayVirtualModelConfigBySlugRequestCaching
    {
        /// <summary>
        ///
        /// </summary>
        x_default,
        /// <summary>
        ///
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateAiGatewayVirtualModelConfigBySlugRequestCachingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAiGatewayVirtualModelConfigBySlugRequestCaching value)
        {
            return value switch
            {
                UpdateAiGatewayVirtualModelConfigBySlugRequestCaching.x_default => "@default",
                UpdateAiGatewayVirtualModelConfigBySlugRequestCaching.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAiGatewayVirtualModelConfigBySlugRequestCaching? ToEnum(string value)
        {
            return value switch
            {
                "@default" => UpdateAiGatewayVirtualModelConfigBySlugRequestCaching.x_default,
                "auto" => UpdateAiGatewayVirtualModelConfigBySlugRequestCaching.Auto,
                _ => null,
            };
        }
    }
}