
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared0b04f80869bc5cc2RoutePrefixSource
    {
        /// <summary>
        ///
        /// </summary>
        Configured,
        /// <summary>
        ///
        /// </summary>
        Generated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared0b04f80869bc5cc2RoutePrefixSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0b04f80869bc5cc2RoutePrefixSource value)
        {
            return value switch
            {
                AutoSDKShared0b04f80869bc5cc2RoutePrefixSource.Configured => "configured",
                AutoSDKShared0b04f80869bc5cc2RoutePrefixSource.Generated => "generated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0b04f80869bc5cc2RoutePrefixSource? ToEnum(string value)
        {
            return value switch
            {
                "configured" => AutoSDKShared0b04f80869bc5cc2RoutePrefixSource.Configured,
                "generated" => AutoSDKShared0b04f80869bc5cc2RoutePrefixSource.Generated,
                _ => null,
            };
        }
    }
}