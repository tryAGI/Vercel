
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateAiGatewayVirtualModelConfigRequestHa
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
        StructuredOutput,
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
    public static class UpdateAiGatewayVirtualModelConfigRequestHaExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAiGatewayVirtualModelConfigRequestHa value)
        {
            return value switch
            {
                UpdateAiGatewayVirtualModelConfigRequestHa.ImplicitCaching => "implicit-caching",
                UpdateAiGatewayVirtualModelConfigRequestHa.Reasoning => "reasoning",
                UpdateAiGatewayVirtualModelConfigRequestHa.StructuredOutput => "structured-output",
                UpdateAiGatewayVirtualModelConfigRequestHa.ToolUse => "tool-use",
                UpdateAiGatewayVirtualModelConfigRequestHa.Vision => "vision",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAiGatewayVirtualModelConfigRequestHa? ToEnum(string value)
        {
            return value switch
            {
                "implicit-caching" => UpdateAiGatewayVirtualModelConfigRequestHa.ImplicitCaching,
                "reasoning" => UpdateAiGatewayVirtualModelConfigRequestHa.Reasoning,
                "structured-output" => UpdateAiGatewayVirtualModelConfigRequestHa.StructuredOutput,
                "tool-use" => UpdateAiGatewayVirtualModelConfigRequestHa.ToolUse,
                "vision" => UpdateAiGatewayVirtualModelConfigRequestHa.Vision,
                _ => null,
            };
        }
    }
}