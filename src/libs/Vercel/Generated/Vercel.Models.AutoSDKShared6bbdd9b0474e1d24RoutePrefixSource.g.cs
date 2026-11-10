
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared6bbdd9b0474e1d24RoutePrefixSource
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
    public static class AutoSDKShared6bbdd9b0474e1d24RoutePrefixSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared6bbdd9b0474e1d24RoutePrefixSource value)
        {
            return value switch
            {
                AutoSDKShared6bbdd9b0474e1d24RoutePrefixSource.Configured => "configured",
                AutoSDKShared6bbdd9b0474e1d24RoutePrefixSource.Generated => "generated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared6bbdd9b0474e1d24RoutePrefixSource? ToEnum(string value)
        {
            return value switch
            {
                "configured" => AutoSDKShared6bbdd9b0474e1d24RoutePrefixSource.Configured,
                "generated" => AutoSDKShared6bbdd9b0474e1d24RoutePrefixSource.Generated,
                _ => null,
            };
        }
    }
}