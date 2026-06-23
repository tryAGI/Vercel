
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum AddRouteResponseRouteRouteTransformVariant1Type
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
    public static class AddRouteResponseRouteRouteTransformVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AddRouteResponseRouteRouteTransformVariant1Type value)
        {
            return value switch
            {
                AddRouteResponseRouteRouteTransformVariant1Type.RequestHeaders => "request.headers",
                AddRouteResponseRouteRouteTransformVariant1Type.RequestQuery => "request.query",
                AddRouteResponseRouteRouteTransformVariant1Type.ResponseHeaders => "response.headers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AddRouteResponseRouteRouteTransformVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "request.headers" => AddRouteResponseRouteRouteTransformVariant1Type.RequestHeaders,
                "request.query" => AddRouteResponseRouteRouteTransformVariant1Type.RequestQuery,
                "response.headers" => AddRouteResponseRouteRouteTransformVariant1Type.ResponseHeaders,
                _ => null,
            };
        }
    }
}