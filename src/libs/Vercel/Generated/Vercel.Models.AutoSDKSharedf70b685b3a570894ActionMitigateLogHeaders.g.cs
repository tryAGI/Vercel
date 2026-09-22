
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedf70b685b3a570894ActionMitigateLogHeaders
    {
        /// <summary>
        ///
        /// </summary>
        Multiply,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedf70b685b3a570894ActionMitigateLogHeadersExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedf70b685b3a570894ActionMitigateLogHeaders value)
        {
            return value switch
            {
                AutoSDKSharedf70b685b3a570894ActionMitigateLogHeaders.Multiply => "*",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedf70b685b3a570894ActionMitigateLogHeaders? ToEnum(string value)
        {
            return value switch
            {
                "*" => AutoSDKSharedf70b685b3a570894ActionMitigateLogHeaders.Multiply,
                _ => null,
            };
        }
    }
}