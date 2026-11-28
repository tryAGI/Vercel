
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Only use the fastest providers, with short timeouts. `null` removes the stored value.
    /// </summary>
    public enum UpdateAiGatewayVirtualModelConfigRequestSpeed
    {
        /// <summary>
        ///
        /// </summary>
        Fast,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateAiGatewayVirtualModelConfigRequestSpeedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAiGatewayVirtualModelConfigRequestSpeed value)
        {
            return value switch
            {
                UpdateAiGatewayVirtualModelConfigRequestSpeed.Fast => "fast",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAiGatewayVirtualModelConfigRequestSpeed? ToEnum(string value)
        {
            return value switch
            {
                "fast" => UpdateAiGatewayVirtualModelConfigRequestSpeed.Fast,
                _ => null,
            };
        }
    }
}