
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared50b8524374e7cff8LogHeaders
    {
        /// <summary>
        ///
        /// </summary>
        Multiply,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared50b8524374e7cff8LogHeadersExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared50b8524374e7cff8LogHeaders value)
        {
            return value switch
            {
                AutoSDKShared50b8524374e7cff8LogHeaders.Multiply => "*",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared50b8524374e7cff8LogHeaders? ToEnum(string value)
        {
            return value switch
            {
                "*" => AutoSDKShared50b8524374e7cff8LogHeaders.Multiply,
                _ => null,
            };
        }
    }
}