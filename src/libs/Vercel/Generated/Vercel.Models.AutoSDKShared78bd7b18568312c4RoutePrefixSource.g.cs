
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared78bd7b18568312c4RoutePrefixSource
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
    public static class AutoSDKShared78bd7b18568312c4RoutePrefixSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared78bd7b18568312c4RoutePrefixSource value)
        {
            return value switch
            {
                AutoSDKShared78bd7b18568312c4RoutePrefixSource.Configured => "configured",
                AutoSDKShared78bd7b18568312c4RoutePrefixSource.Generated => "generated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared78bd7b18568312c4RoutePrefixSource? ToEnum(string value)
        {
            return value switch
            {
                "configured" => AutoSDKShared78bd7b18568312c4RoutePrefixSource.Configured,
                "generated" => AutoSDKShared78bd7b18568312c4RoutePrefixSource.Generated,
                _ => null,
            };
        }
    }
}