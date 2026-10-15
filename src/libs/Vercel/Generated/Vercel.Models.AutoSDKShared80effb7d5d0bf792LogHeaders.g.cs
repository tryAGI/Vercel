
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared80effb7d5d0bf792LogHeaders
    {
        /// <summary>
        ///
        /// </summary>
        Multiply,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared80effb7d5d0bf792LogHeadersExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared80effb7d5d0bf792LogHeaders value)
        {
            return value switch
            {
                AutoSDKShared80effb7d5d0bf792LogHeaders.Multiply => "*",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared80effb7d5d0bf792LogHeaders? ToEnum(string value)
        {
            return value switch
            {
                "*" => AutoSDKShared80effb7d5d0bf792LogHeaders.Multiply,
                _ => null,
            };
        }
    }
}