
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared258edac9bcd00342RouteType
    {
        /// <summary>
        ///
        /// </summary>
        Redirect,
        /// <summary>
        ///
        /// </summary>
        Rewrite,
        /// <summary>
        ///
        /// </summary>
        SetStatus,
        /// <summary>
        ///
        /// </summary>
        Transform,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared258edac9bcd00342RouteTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared258edac9bcd00342RouteType value)
        {
            return value switch
            {
                AutoSDKShared258edac9bcd00342RouteType.Redirect => "redirect",
                AutoSDKShared258edac9bcd00342RouteType.Rewrite => "rewrite",
                AutoSDKShared258edac9bcd00342RouteType.SetStatus => "set_status",
                AutoSDKShared258edac9bcd00342RouteType.Transform => "transform",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared258edac9bcd00342RouteType? ToEnum(string value)
        {
            return value switch
            {
                "redirect" => AutoSDKShared258edac9bcd00342RouteType.Redirect,
                "rewrite" => AutoSDKShared258edac9bcd00342RouteType.Rewrite,
                "set_status" => AutoSDKShared258edac9bcd00342RouteType.SetStatus,
                "transform" => AutoSDKShared258edac9bcd00342RouteType.Transform,
                _ => null,
            };
        }
    }
}