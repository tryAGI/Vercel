
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Computed route type based on the route configuration. Only present in API responses, not stored in S3.
    /// </summary>
    public enum AutoSDKSharedb49e2a5785c6f473RouteType
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
    public static class AutoSDKSharedb49e2a5785c6f473RouteTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedb49e2a5785c6f473RouteType value)
        {
            return value switch
            {
                AutoSDKSharedb49e2a5785c6f473RouteType.Redirect => "redirect",
                AutoSDKSharedb49e2a5785c6f473RouteType.Rewrite => "rewrite",
                AutoSDKSharedb49e2a5785c6f473RouteType.SetStatus => "set_status",
                AutoSDKSharedb49e2a5785c6f473RouteType.Transform => "transform",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedb49e2a5785c6f473RouteType? ToEnum(string value)
        {
            return value switch
            {
                "redirect" => AutoSDKSharedb49e2a5785c6f473RouteType.Redirect,
                "rewrite" => AutoSDKSharedb49e2a5785c6f473RouteType.Rewrite,
                "set_status" => AutoSDKSharedb49e2a5785c6f473RouteType.SetStatus,
                "transform" => AutoSDKSharedb49e2a5785c6f473RouteType.Transform,
                _ => null,
            };
        }
    }
}