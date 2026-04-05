
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetRoutesResponseVariant2RouteRouteTransformType
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
    public static class GetRoutesResponseVariant2RouteRouteTransformTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRoutesResponseVariant2RouteRouteTransformType value)
        {
            return value switch
            {
                GetRoutesResponseVariant2RouteRouteTransformType.RequestHeaders => "request.headers",
                GetRoutesResponseVariant2RouteRouteTransformType.RequestQuery => "request.query",
                GetRoutesResponseVariant2RouteRouteTransformType.ResponseHeaders => "response.headers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRoutesResponseVariant2RouteRouteTransformType? ToEnum(string value)
        {
            return value switch
            {
                "request.headers" => GetRoutesResponseVariant2RouteRouteTransformType.RequestHeaders,
                "request.query" => GetRoutesResponseVariant2RouteRouteTransformType.RequestQuery,
                "response.headers" => GetRoutesResponseVariant2RouteRouteTransformType.ResponseHeaders,
                _ => null,
            };
        }
    }
}