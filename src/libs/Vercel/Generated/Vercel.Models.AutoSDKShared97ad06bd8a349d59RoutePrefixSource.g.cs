
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared97ad06bd8a349d59RoutePrefixSource
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
    public static class AutoSDKShared97ad06bd8a349d59RoutePrefixSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared97ad06bd8a349d59RoutePrefixSource value)
        {
            return value switch
            {
                AutoSDKShared97ad06bd8a349d59RoutePrefixSource.Configured => "configured",
                AutoSDKShared97ad06bd8a349d59RoutePrefixSource.Generated => "generated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared97ad06bd8a349d59RoutePrefixSource? ToEnum(string value)
        {
            return value switch
            {
                "configured" => AutoSDKShared97ad06bd8a349d59RoutePrefixSource.Configured,
                "generated" => AutoSDKShared97ad06bd8a349d59RoutePrefixSource.Generated,
                _ => null,
            };
        }
    }
}