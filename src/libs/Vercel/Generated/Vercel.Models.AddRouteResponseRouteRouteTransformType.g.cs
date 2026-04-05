
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum AddRouteResponseRouteRouteTransformType
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
    public static class AddRouteResponseRouteRouteTransformTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AddRouteResponseRouteRouteTransformType value)
        {
            return value switch
            {
                AddRouteResponseRouteRouteTransformType.RequestHeaders => "request.headers",
                AddRouteResponseRouteRouteTransformType.RequestQuery => "request.query",
                AddRouteResponseRouteRouteTransformType.ResponseHeaders => "response.headers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AddRouteResponseRouteRouteTransformType? ToEnum(string value)
        {
            return value switch
            {
                "request.headers" => AddRouteResponseRouteRouteTransformType.RequestHeaders,
                "request.query" => AddRouteResponseRouteRouteTransformType.RequestQuery,
                "response.headers" => AddRouteResponseRouteRouteTransformType.ResponseHeaders,
                _ => null,
            };
        }
    }
}