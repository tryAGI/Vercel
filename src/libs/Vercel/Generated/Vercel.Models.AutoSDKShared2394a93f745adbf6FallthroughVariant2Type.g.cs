
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared2394a93f745adbf6FallthroughVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        Split,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared2394a93f745adbf6FallthroughVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared2394a93f745adbf6FallthroughVariant2Type value)
        {
            return value switch
            {
                AutoSDKShared2394a93f745adbf6FallthroughVariant2Type.Split => "split",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared2394a93f745adbf6FallthroughVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "split" => AutoSDKShared2394a93f745adbf6FallthroughVariant2Type.Split,
                _ => null,
            };
        }
    }
}