
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared9a99a7cde55f3566RulesetsLogHeaders
    {
        /// <summary>
        ///
        /// </summary>
        Multiply,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared9a99a7cde55f3566RulesetsLogHeadersExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared9a99a7cde55f3566RulesetsLogHeaders value)
        {
            return value switch
            {
                AutoSDKShared9a99a7cde55f3566RulesetsLogHeaders.Multiply => "*",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared9a99a7cde55f3566RulesetsLogHeaders? ToEnum(string value)
        {
            return value switch
            {
                "*" => AutoSDKShared9a99a7cde55f3566RulesetsLogHeaders.Multiply,
                _ => null,
            };
        }
    }
}