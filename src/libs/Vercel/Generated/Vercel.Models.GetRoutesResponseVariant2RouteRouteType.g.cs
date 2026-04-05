
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Computed route type based on the route configuration. Only present in API responses, not stored in S3.
    /// </summary>
    public enum GetRoutesResponseVariant2RouteRouteType
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
    public static class GetRoutesResponseVariant2RouteRouteTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRoutesResponseVariant2RouteRouteType value)
        {
            return value switch
            {
                GetRoutesResponseVariant2RouteRouteType.Redirect => "redirect",
                GetRoutesResponseVariant2RouteRouteType.Rewrite => "rewrite",
                GetRoutesResponseVariant2RouteRouteType.SetStatus => "set_status",
                GetRoutesResponseVariant2RouteRouteType.Transform => "transform",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRoutesResponseVariant2RouteRouteType? ToEnum(string value)
        {
            return value switch
            {
                "redirect" => GetRoutesResponseVariant2RouteRouteType.Redirect,
                "rewrite" => GetRoutesResponseVariant2RouteRouteType.Rewrite,
                "set_status" => GetRoutesResponseVariant2RouteRouteType.SetStatus,
                "transform" => GetRoutesResponseVariant2RouteRouteType.Transform,
                _ => null,
            };
        }
    }
}