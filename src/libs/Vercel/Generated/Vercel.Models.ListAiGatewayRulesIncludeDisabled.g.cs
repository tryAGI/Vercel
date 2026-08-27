
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum ListAiGatewayRulesIncludeDisabled
    {
        /// <summary>
        ///
        /// </summary>
        False,
        /// <summary>
        ///
        /// </summary>
        True,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListAiGatewayRulesIncludeDisabledExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAiGatewayRulesIncludeDisabled value)
        {
            return value switch
            {
                ListAiGatewayRulesIncludeDisabled.False => "false",
                ListAiGatewayRulesIncludeDisabled.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAiGatewayRulesIncludeDisabled? ToEnum(string value)
        {
            return value switch
            {
                "false" => ListAiGatewayRulesIncludeDisabled.False,
                "true" => ListAiGatewayRulesIncludeDisabled.True,
                _ => null,
            };
        }
    }
}