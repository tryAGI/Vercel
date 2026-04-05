
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Computed route type based on the route configuration. Only present in API responses, not stored in S3.
    /// </summary>
    public enum GetRoutesResponseVariant4RouteRouteType
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
    public static class GetRoutesResponseVariant4RouteRouteTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRoutesResponseVariant4RouteRouteType value)
        {
            return value switch
            {
                GetRoutesResponseVariant4RouteRouteType.Redirect => "redirect",
                GetRoutesResponseVariant4RouteRouteType.Rewrite => "rewrite",
                GetRoutesResponseVariant4RouteRouteType.SetStatus => "set_status",
                GetRoutesResponseVariant4RouteRouteType.Transform => "transform",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRoutesResponseVariant4RouteRouteType? ToEnum(string value)
        {
            return value switch
            {
                "redirect" => GetRoutesResponseVariant4RouteRouteType.Redirect,
                "rewrite" => GetRoutesResponseVariant4RouteRouteType.Rewrite,
                "set_status" => GetRoutesResponseVariant4RouteRouteType.SetStatus,
                "transform" => GetRoutesResponseVariant4RouteRouteType.Transform,
                _ => null,
            };
        }
    }
}