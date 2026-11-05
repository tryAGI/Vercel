
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedeb5fe0ead5db865cLogHeaders
    {
        /// <summary>
        ///
        /// </summary>
        Multiply,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedeb5fe0ead5db865cLogHeadersExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedeb5fe0ead5db865cLogHeaders value)
        {
            return value switch
            {
                AutoSDKSharedeb5fe0ead5db865cLogHeaders.Multiply => "*",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedeb5fe0ead5db865cLogHeaders? ToEnum(string value)
        {
            return value switch
            {
                "*" => AutoSDKSharedeb5fe0ead5db865cLogHeaders.Multiply,
                _ => null,
            };
        }
    }
}