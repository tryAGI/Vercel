
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Use caching if available. `@default` ignores the value from the inference request.
    /// </summary>
    public enum CreateAiGatewayVirtualModelConfigRequestCaching
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
    public static class CreateAiGatewayVirtualModelConfigRequestCachingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAiGatewayVirtualModelConfigRequestCaching value)
        {
            return value switch
            {
                CreateAiGatewayVirtualModelConfigRequestCaching.x_default => "@default",
                CreateAiGatewayVirtualModelConfigRequestCaching.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAiGatewayVirtualModelConfigRequestCaching? ToEnum(string value)
        {
            return value switch
            {
                "@default" => CreateAiGatewayVirtualModelConfigRequestCaching.x_default,
                "auto" => CreateAiGatewayVirtualModelConfigRequestCaching.Auto,
                _ => null,
            };
        }
    }
}