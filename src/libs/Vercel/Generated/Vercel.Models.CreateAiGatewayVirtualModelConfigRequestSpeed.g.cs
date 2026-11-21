
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Only use the fastest providers, with short timeouts.
    /// </summary>
    public enum CreateAiGatewayVirtualModelConfigRequestSpeed
    {
        /// <summary>
        ///
        /// </summary>
        Fast,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateAiGatewayVirtualModelConfigRequestSpeedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAiGatewayVirtualModelConfigRequestSpeed value)
        {
            return value switch
            {
                CreateAiGatewayVirtualModelConfigRequestSpeed.Fast => "fast",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAiGatewayVirtualModelConfigRequestSpeed? ToEnum(string value)
        {
            return value switch
            {
                "fast" => CreateAiGatewayVirtualModelConfigRequestSpeed.Fast,
                _ => null,
            };
        }
    }
}