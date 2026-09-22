
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Computed route type based on the route configuration. Only present in API responses, not stored in S3.
    /// </summary>
    public enum AutoSDKShared6ce7a2d665426cb4RouteType
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
    public static class AutoSDKShared6ce7a2d665426cb4RouteTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared6ce7a2d665426cb4RouteType value)
        {
            return value switch
            {
                AutoSDKShared6ce7a2d665426cb4RouteType.Redirect => "redirect",
                AutoSDKShared6ce7a2d665426cb4RouteType.Rewrite => "rewrite",
                AutoSDKShared6ce7a2d665426cb4RouteType.SetStatus => "set_status",
                AutoSDKShared6ce7a2d665426cb4RouteType.Transform => "transform",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared6ce7a2d665426cb4RouteType? ToEnum(string value)
        {
            return value switch
            {
                "redirect" => AutoSDKShared6ce7a2d665426cb4RouteType.Redirect,
                "rewrite" => AutoSDKShared6ce7a2d665426cb4RouteType.Rewrite,
                "set_status" => AutoSDKShared6ce7a2d665426cb4RouteType.SetStatus,
                "transform" => AutoSDKShared6ce7a2d665426cb4RouteType.Transform,
                _ => null,
            };
        }
    }
}