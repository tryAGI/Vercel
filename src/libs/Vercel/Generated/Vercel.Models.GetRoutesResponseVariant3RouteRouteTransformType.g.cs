
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetRoutesResponseVariant3RouteRouteTransformType
    {
        /// <summary>
        /// 
        /// </summary>
        RequestHeaders,
        /// <summary>
        /// 
        /// </summary>
        RequestQuery,
        /// <summary>
        /// 
        /// </summary>
        ResponseHeaders,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetRoutesResponseVariant3RouteRouteTransformTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRoutesResponseVariant3RouteRouteTransformType value)
        {
            return value switch
            {
                GetRoutesResponseVariant3RouteRouteTransformType.RequestHeaders => "request.headers",
                GetRoutesResponseVariant3RouteRouteTransformType.RequestQuery => "request.query",
                GetRoutesResponseVariant3RouteRouteTransformType.ResponseHeaders => "response.headers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRoutesResponseVariant3RouteRouteTransformType? ToEnum(string value)
        {
            return value switch
            {
                "request.headers" => GetRoutesResponseVariant3RouteRouteTransformType.RequestHeaders,
                "request.query" => GetRoutesResponseVariant3RouteRouteTransformType.RequestQuery,
                "response.headers" => GetRoutesResponseVariant3RouteRouteTransformType.ResponseHeaders,
                _ => null,
            };
        }
    }
}