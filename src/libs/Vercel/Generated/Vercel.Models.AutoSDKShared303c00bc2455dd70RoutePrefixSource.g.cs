
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared303c00bc2455dd70RoutePrefixSource
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
    public static class AutoSDKShared303c00bc2455dd70RoutePrefixSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared303c00bc2455dd70RoutePrefixSource value)
        {
            return value switch
            {
                AutoSDKShared303c00bc2455dd70RoutePrefixSource.Configured => "configured",
                AutoSDKShared303c00bc2455dd70RoutePrefixSource.Generated => "generated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared303c00bc2455dd70RoutePrefixSource? ToEnum(string value)
        {
            return value switch
            {
                "configured" => AutoSDKShared303c00bc2455dd70RoutePrefixSource.Configured,
                "generated" => AutoSDKShared303c00bc2455dd70RoutePrefixSource.Generated,
                _ => null,
            };
        }
    }
}