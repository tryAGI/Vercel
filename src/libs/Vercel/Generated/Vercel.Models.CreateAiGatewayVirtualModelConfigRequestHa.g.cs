
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateAiGatewayVirtualModelConfigRequestHa
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
    public static class CreateAiGatewayVirtualModelConfigRequestHaExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAiGatewayVirtualModelConfigRequestHa value)
        {
            return value switch
            {
                CreateAiGatewayVirtualModelConfigRequestHa.ImplicitCaching => "implicit-caching",
                CreateAiGatewayVirtualModelConfigRequestHa.Reasoning => "reasoning",
                CreateAiGatewayVirtualModelConfigRequestHa.StructuredOutput => "structured-output",
                CreateAiGatewayVirtualModelConfigRequestHa.ToolUse => "tool-use",
                CreateAiGatewayVirtualModelConfigRequestHa.Vision => "vision",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAiGatewayVirtualModelConfigRequestHa? ToEnum(string value)
        {
            return value switch
            {
                "implicit-caching" => CreateAiGatewayVirtualModelConfigRequestHa.ImplicitCaching,
                "reasoning" => CreateAiGatewayVirtualModelConfigRequestHa.Reasoning,
                "structured-output" => CreateAiGatewayVirtualModelConfigRequestHa.StructuredOutput,
                "tool-use" => CreateAiGatewayVirtualModelConfigRequestHa.ToolUse,
                "vision" => CreateAiGatewayVirtualModelConfigRequestHa.Vision,
                _ => null,
            };
        }
    }
}