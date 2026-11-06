
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared25e1e81cf9eecd30LogHeaders
    {
        /// <summary>
        ///
        /// </summary>
        Multiply,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared25e1e81cf9eecd30LogHeadersExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared25e1e81cf9eecd30LogHeaders value)
        {
            return value switch
            {
                AutoSDKShared25e1e81cf9eecd30LogHeaders.Multiply => "*",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared25e1e81cf9eecd30LogHeaders? ToEnum(string value)
        {
            return value switch
            {
                "*" => AutoSDKShared25e1e81cf9eecd30LogHeaders.Multiply,
                _ => null,
            };
        }
    }
}