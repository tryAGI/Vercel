
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Use caching if available. `@default` ignores the value from the inference request. `null` removes the stored value.
    /// </summary>
    public enum UpdateAiGatewayVirtualModelConfigRequestCaching
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
    public static class UpdateAiGatewayVirtualModelConfigRequestCachingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAiGatewayVirtualModelConfigRequestCaching value)
        {
            return value switch
            {
                UpdateAiGatewayVirtualModelConfigRequestCaching.x_default => "@default",
                UpdateAiGatewayVirtualModelConfigRequestCaching.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAiGatewayVirtualModelConfigRequestCaching? ToEnum(string value)
        {
            return value switch
            {
                "@default" => UpdateAiGatewayVirtualModelConfigRequestCaching.x_default,
                "auto" => UpdateAiGatewayVirtualModelConfigRequestCaching.Auto,
                _ => null,
            };
        }
    }
}