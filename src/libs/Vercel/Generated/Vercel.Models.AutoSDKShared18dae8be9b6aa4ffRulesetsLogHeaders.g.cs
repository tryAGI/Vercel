
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared18dae8be9b6aa4ffRulesetsLogHeaders
    {
        /// <summary>
        ///
        /// </summary>
        Multiply,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared18dae8be9b6aa4ffRulesetsLogHeadersExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared18dae8be9b6aa4ffRulesetsLogHeaders value)
        {
            return value switch
            {
                AutoSDKShared18dae8be9b6aa4ffRulesetsLogHeaders.Multiply => "*",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared18dae8be9b6aa4ffRulesetsLogHeaders? ToEnum(string value)
        {
            return value switch
            {
                "*" => AutoSDKShared18dae8be9b6aa4ffRulesetsLogHeaders.Multiply,
                _ => null,
            };
        }
    }
}