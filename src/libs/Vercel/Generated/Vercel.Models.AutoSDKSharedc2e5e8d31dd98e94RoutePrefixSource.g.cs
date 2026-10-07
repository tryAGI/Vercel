
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedc2e5e8d31dd98e94RoutePrefixSource
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
    public static class AutoSDKSharedc2e5e8d31dd98e94RoutePrefixSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedc2e5e8d31dd98e94RoutePrefixSource value)
        {
            return value switch
            {
                AutoSDKSharedc2e5e8d31dd98e94RoutePrefixSource.Configured => "configured",
                AutoSDKSharedc2e5e8d31dd98e94RoutePrefixSource.Generated => "generated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedc2e5e8d31dd98e94RoutePrefixSource? ToEnum(string value)
        {
            return value switch
            {
                "configured" => AutoSDKSharedc2e5e8d31dd98e94RoutePrefixSource.Configured,
                "generated" => AutoSDKSharedc2e5e8d31dd98e94RoutePrefixSource.Generated,
                _ => null,
            };
        }
    }
}