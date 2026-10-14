
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Whether to include rows inherited from a budget default (`source: "default"`). Defaults to true.
    /// </summary>
    public enum ListAiGatewayBudgetsIncludeDefaultCovered
    {
        /// <summary>
        ///
        /// </summary>
        False,
        /// <summary>
        /// "default"`). Defaults to true.
        /// </summary>
        True,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListAiGatewayBudgetsIncludeDefaultCoveredExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAiGatewayBudgetsIncludeDefaultCovered value)
        {
            return value switch
            {
                ListAiGatewayBudgetsIncludeDefaultCovered.False => "false",
                ListAiGatewayBudgetsIncludeDefaultCovered.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAiGatewayBudgetsIncludeDefaultCovered? ToEnum(string value)
        {
            return value switch
            {
                "false" => ListAiGatewayBudgetsIncludeDefaultCovered.False,
                "true" => ListAiGatewayBudgetsIncludeDefaultCovered.True,
                _ => null,
            };
        }
    }
}