
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateAiGatewayVirtualModelConfigBySlugRequestHa
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
    public static class UpdateAiGatewayVirtualModelConfigBySlugRequestHaExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAiGatewayVirtualModelConfigBySlugRequestHa value)
        {
            return value switch
            {
                UpdateAiGatewayVirtualModelConfigBySlugRequestHa.ImplicitCaching => "implicit-caching",
                UpdateAiGatewayVirtualModelConfigBySlugRequestHa.Reasoning => "reasoning",
                UpdateAiGatewayVirtualModelConfigBySlugRequestHa.StructuredOutput => "structured-output",
                UpdateAiGatewayVirtualModelConfigBySlugRequestHa.ToolUse => "tool-use",
                UpdateAiGatewayVirtualModelConfigBySlugRequestHa.Vision => "vision",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAiGatewayVirtualModelConfigBySlugRequestHa? ToEnum(string value)
        {
            return value switch
            {
                "implicit-caching" => UpdateAiGatewayVirtualModelConfigBySlugRequestHa.ImplicitCaching,
                "reasoning" => UpdateAiGatewayVirtualModelConfigBySlugRequestHa.Reasoning,
                "structured-output" => UpdateAiGatewayVirtualModelConfigBySlugRequestHa.StructuredOutput,
                "tool-use" => UpdateAiGatewayVirtualModelConfigBySlugRequestHa.ToolUse,
                "vision" => UpdateAiGatewayVirtualModelConfigBySlugRequestHa.Vision,
                _ => null,
            };
        }
    }
}