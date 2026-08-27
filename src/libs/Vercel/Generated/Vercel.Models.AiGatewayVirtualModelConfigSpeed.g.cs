
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Only use fastest providers with short timeouts.
    /// </summary>
    public enum AiGatewayVirtualModelConfigSpeed
    {
        /// <summary>
        ///
        /// </summary>
        Fast,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AiGatewayVirtualModelConfigSpeedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiGatewayVirtualModelConfigSpeed value)
        {
            return value switch
            {
                AiGatewayVirtualModelConfigSpeed.Fast => "fast",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiGatewayVirtualModelConfigSpeed? ToEnum(string value)
        {
            return value switch
            {
                "fast" => AiGatewayVirtualModelConfigSpeed.Fast,
                _ => null,
            };
        }
    }
}