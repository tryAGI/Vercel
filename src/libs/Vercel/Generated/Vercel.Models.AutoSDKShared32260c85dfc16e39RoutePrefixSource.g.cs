
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared32260c85dfc16e39RoutePrefixSource
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
    public static class AutoSDKShared32260c85dfc16e39RoutePrefixSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared32260c85dfc16e39RoutePrefixSource value)
        {
            return value switch
            {
                AutoSDKShared32260c85dfc16e39RoutePrefixSource.Configured => "configured",
                AutoSDKShared32260c85dfc16e39RoutePrefixSource.Generated => "generated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared32260c85dfc16e39RoutePrefixSource? ToEnum(string value)
        {
            return value switch
            {
                "configured" => AutoSDKShared32260c85dfc16e39RoutePrefixSource.Configured,
                "generated" => AutoSDKShared32260c85dfc16e39RoutePrefixSource.Generated,
                _ => null,
            };
        }
    }
}