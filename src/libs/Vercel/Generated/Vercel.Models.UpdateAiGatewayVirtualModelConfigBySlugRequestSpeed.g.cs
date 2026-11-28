
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Only use the fastest providers, with short timeouts. `null` removes the stored value.
    /// </summary>
    public enum UpdateAiGatewayVirtualModelConfigBySlugRequestSpeed
    {
        /// <summary>
        ///
        /// </summary>
        Fast,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateAiGatewayVirtualModelConfigBySlugRequestSpeedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAiGatewayVirtualModelConfigBySlugRequestSpeed value)
        {
            return value switch
            {
                UpdateAiGatewayVirtualModelConfigBySlugRequestSpeed.Fast => "fast",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAiGatewayVirtualModelConfigBySlugRequestSpeed? ToEnum(string value)
        {
            return value switch
            {
                "fast" => UpdateAiGatewayVirtualModelConfigBySlugRequestSpeed.Fast,
                _ => null,
            };
        }
    }
}