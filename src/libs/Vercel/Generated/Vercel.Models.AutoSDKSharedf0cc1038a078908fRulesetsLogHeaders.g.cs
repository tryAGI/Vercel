
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedf0cc1038a078908fRulesetsLogHeaders
    {
        /// <summary>
        ///
        /// </summary>
        Multiply,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedf0cc1038a078908fRulesetsLogHeadersExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedf0cc1038a078908fRulesetsLogHeaders value)
        {
            return value switch
            {
                AutoSDKSharedf0cc1038a078908fRulesetsLogHeaders.Multiply => "*",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedf0cc1038a078908fRulesetsLogHeaders? ToEnum(string value)
        {
            return value switch
            {
                "*" => AutoSDKSharedf0cc1038a078908fRulesetsLogHeaders.Multiply,
                _ => null,
            };
        }
    }
}