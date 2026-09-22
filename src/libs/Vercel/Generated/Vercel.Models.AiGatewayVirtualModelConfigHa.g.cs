
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Limit providers to those with these features.
    /// </summary>
    public enum AiGatewayVirtualModelConfigHa
    {
        /// <summary>
        ///
        /// </summary>
        ImplicitCaching,
        /// <summary>
        ///
        /// </summary>
        Reasoning,
        /// <summary>
        ///
        /// </summary>
        ToolUse,
        /// <summary>
        ///
        /// </summary>
        Vision,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AiGatewayVirtualModelConfigHaExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiGatewayVirtualModelConfigHa value)
        {
            return value switch
            {
                AiGatewayVirtualModelConfigHa.ImplicitCaching => "implicit-caching",
                AiGatewayVirtualModelConfigHa.Reasoning => "reasoning",
                AiGatewayVirtualModelConfigHa.ToolUse => "tool-use",
                AiGatewayVirtualModelConfigHa.Vision => "vision",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiGatewayVirtualModelConfigHa? ToEnum(string value)
        {
            return value switch
            {
                "implicit-caching" => AiGatewayVirtualModelConfigHa.ImplicitCaching,
                "reasoning" => AiGatewayVirtualModelConfigHa.Reasoning,
                "tool-use" => AiGatewayVirtualModelConfigHa.ToolUse,
                "vision" => AiGatewayVirtualModelConfigHa.Vision,
                _ => null,
            };
        }
    }
}