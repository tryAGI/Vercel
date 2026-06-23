
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetRoutesResponseVariant3RouteRouteTransformVariant1Type
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
    public static class GetRoutesResponseVariant3RouteRouteTransformVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRoutesResponseVariant3RouteRouteTransformVariant1Type value)
        {
            return value switch
            {
                GetRoutesResponseVariant3RouteRouteTransformVariant1Type.RequestHeaders => "request.headers",
                GetRoutesResponseVariant3RouteRouteTransformVariant1Type.RequestQuery => "request.query",
                GetRoutesResponseVariant3RouteRouteTransformVariant1Type.ResponseHeaders => "response.headers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRoutesResponseVariant3RouteRouteTransformVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "request.headers" => GetRoutesResponseVariant3RouteRouteTransformVariant1Type.RequestHeaders,
                "request.query" => GetRoutesResponseVariant3RouteRouteTransformVariant1Type.RequestQuery,
                "response.headers" => GetRoutesResponseVariant3RouteRouteTransformVariant1Type.ResponseHeaders,
                _ => null,
            };
        }
    }
}