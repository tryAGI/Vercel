
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared03f29e765d13306dRoutePrefixSource
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
    public static class AutoSDKShared03f29e765d13306dRoutePrefixSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared03f29e765d13306dRoutePrefixSource value)
        {
            return value switch
            {
                AutoSDKShared03f29e765d13306dRoutePrefixSource.Configured => "configured",
                AutoSDKShared03f29e765d13306dRoutePrefixSource.Generated => "generated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared03f29e765d13306dRoutePrefixSource? ToEnum(string value)
        {
            return value switch
            {
                "configured" => AutoSDKShared03f29e765d13306dRoutePrefixSource.Configured,
                "generated" => AutoSDKShared03f29e765d13306dRoutePrefixSource.Generated,
                _ => null,
            };
        }
    }
}