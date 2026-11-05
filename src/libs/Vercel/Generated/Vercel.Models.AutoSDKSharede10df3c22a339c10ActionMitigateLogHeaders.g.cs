
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharede10df3c22a339c10ActionMitigateLogHeaders
    {
        /// <summary>
        ///
        /// </summary>
        Multiply,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharede10df3c22a339c10ActionMitigateLogHeadersExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede10df3c22a339c10ActionMitigateLogHeaders value)
        {
            return value switch
            {
                AutoSDKSharede10df3c22a339c10ActionMitigateLogHeaders.Multiply => "*",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede10df3c22a339c10ActionMitigateLogHeaders? ToEnum(string value)
        {
            return value switch
            {
                "*" => AutoSDKSharede10df3c22a339c10ActionMitigateLogHeaders.Multiply,
                _ => null,
            };
        }
    }
}