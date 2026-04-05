
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetRoutesResponseVariant4RouteRouteHaVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Cookie,
        /// <summary>
        /// 
        /// </summary>
        Header,
        /// <summary>
        /// 
        /// </summary>
        Query,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetRoutesResponseVariant4RouteRouteHaVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRoutesResponseVariant4RouteRouteHaVariant2Type value)
        {
            return value switch
            {
                GetRoutesResponseVariant4RouteRouteHaVariant2Type.Cookie => "cookie",
                GetRoutesResponseVariant4RouteRouteHaVariant2Type.Header => "header",
                GetRoutesResponseVariant4RouteRouteHaVariant2Type.Query => "query",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRoutesResponseVariant4RouteRouteHaVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "cookie" => GetRoutesResponseVariant4RouteRouteHaVariant2Type.Cookie,
                "header" => GetRoutesResponseVariant4RouteRouteHaVariant2Type.Header,
                "query" => GetRoutesResponseVariant4RouteRouteHaVariant2Type.Query,
                _ => null,
            };
        }
    }
}