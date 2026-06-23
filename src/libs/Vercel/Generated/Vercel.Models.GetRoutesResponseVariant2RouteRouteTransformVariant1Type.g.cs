
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetRoutesResponseVariant2RouteRouteTransformVariant1Type
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
    public static class GetRoutesResponseVariant2RouteRouteTransformVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRoutesResponseVariant2RouteRouteTransformVariant1Type value)
        {
            return value switch
            {
                GetRoutesResponseVariant2RouteRouteTransformVariant1Type.RequestHeaders => "request.headers",
                GetRoutesResponseVariant2RouteRouteTransformVariant1Type.RequestQuery => "request.query",
                GetRoutesResponseVariant2RouteRouteTransformVariant1Type.ResponseHeaders => "response.headers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRoutesResponseVariant2RouteRouteTransformVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "request.headers" => GetRoutesResponseVariant2RouteRouteTransformVariant1Type.RequestHeaders,
                "request.query" => GetRoutesResponseVariant2RouteRouteTransformVariant1Type.RequestQuery,
                "response.headers" => GetRoutesResponseVariant2RouteRouteTransformVariant1Type.ResponseHeaders,
                _ => null,
            };
        }
    }
}