
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetRoutesResponseVariant4RouteRouteTransformVariant1Type
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
    public static class GetRoutesResponseVariant4RouteRouteTransformVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRoutesResponseVariant4RouteRouteTransformVariant1Type value)
        {
            return value switch
            {
                GetRoutesResponseVariant4RouteRouteTransformVariant1Type.RequestHeaders => "request.headers",
                GetRoutesResponseVariant4RouteRouteTransformVariant1Type.RequestQuery => "request.query",
                GetRoutesResponseVariant4RouteRouteTransformVariant1Type.ResponseHeaders => "response.headers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRoutesResponseVariant4RouteRouteTransformVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "request.headers" => GetRoutesResponseVariant4RouteRouteTransformVariant1Type.RequestHeaders,
                "request.query" => GetRoutesResponseVariant4RouteRouteTransformVariant1Type.RequestQuery,
                "response.headers" => GetRoutesResponseVariant4RouteRouteTransformVariant1Type.ResponseHeaders,
                _ => null,
            };
        }
    }
}