
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared9a99a7cde55f3566LogHeaders
    {
        /// <summary>
        ///
        /// </summary>
        Multiply,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared9a99a7cde55f3566LogHeadersExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared9a99a7cde55f3566LogHeaders value)
        {
            return value switch
            {
                AutoSDKShared9a99a7cde55f3566LogHeaders.Multiply => "*",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared9a99a7cde55f3566LogHeaders? ToEnum(string value)
        {
            return value switch
            {
                "*" => AutoSDKShared9a99a7cde55f3566LogHeaders.Multiply,
                _ => null,
            };
        }
    }
}