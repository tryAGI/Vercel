
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Computed route type based on the route configuration. Only present in API responses, not stored in S3.
    /// </summary>
    public enum GetRoutesResponseVariant3RouteRouteType
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
    public static class GetRoutesResponseVariant3RouteRouteTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRoutesResponseVariant3RouteRouteType value)
        {
            return value switch
            {
                GetRoutesResponseVariant3RouteRouteType.Redirect => "redirect",
                GetRoutesResponseVariant3RouteRouteType.Rewrite => "rewrite",
                GetRoutesResponseVariant3RouteRouteType.SetStatus => "set_status",
                GetRoutesResponseVariant3RouteRouteType.Transform => "transform",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRoutesResponseVariant3RouteRouteType? ToEnum(string value)
        {
            return value switch
            {
                "redirect" => GetRoutesResponseVariant3RouteRouteType.Redirect,
                "rewrite" => GetRoutesResponseVariant3RouteRouteType.Rewrite,
                "set_status" => GetRoutesResponseVariant3RouteRouteType.SetStatus,
                "transform" => GetRoutesResponseVariant3RouteRouteType.Transform,
                _ => null,
            };
        }
    }
}