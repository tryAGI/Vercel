
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetRoutesResponseVariant4RouteRouteTransformType
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
    public static class GetRoutesResponseVariant4RouteRouteTransformTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRoutesResponseVariant4RouteRouteTransformType value)
        {
            return value switch
            {
                GetRoutesResponseVariant4RouteRouteTransformType.RequestHeaders => "request.headers",
                GetRoutesResponseVariant4RouteRouteTransformType.RequestQuery => "request.query",
                GetRoutesResponseVariant4RouteRouteTransformType.ResponseHeaders => "response.headers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRoutesResponseVariant4RouteRouteTransformType? ToEnum(string value)
        {
            return value switch
            {
                "request.headers" => GetRoutesResponseVariant4RouteRouteTransformType.RequestHeaders,
                "request.query" => GetRoutesResponseVariant4RouteRouteTransformType.RequestQuery,
                "response.headers" => GetRoutesResponseVariant4RouteRouteTransformType.ResponseHeaders,
                _ => null,
            };
        }
    }
}