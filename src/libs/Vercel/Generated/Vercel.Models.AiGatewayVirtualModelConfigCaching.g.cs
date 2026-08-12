
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Use caching if available.
    /// </summary>
    public enum AiGatewayVirtualModelConfigCaching
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AiGatewayVirtualModelConfigCachingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiGatewayVirtualModelConfigCaching value)
        {
            return value switch
            {
                AiGatewayVirtualModelConfigCaching.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiGatewayVirtualModelConfigCaching? ToEnum(string value)
        {
            return value switch
            {
                "auto" => AiGatewayVirtualModelConfigCaching.Auto,
                _ => null,
            };
        }
    }
}