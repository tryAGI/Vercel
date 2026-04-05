
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum AddRouteRequestRouteRouteTransformType
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
    public static class AddRouteRequestRouteRouteTransformTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AddRouteRequestRouteRouteTransformType value)
        {
            return value switch
            {
                AddRouteRequestRouteRouteTransformType.RequestHeaders => "request.headers",
                AddRouteRequestRouteRouteTransformType.RequestQuery => "request.query",
                AddRouteRequestRouteRouteTransformType.ResponseHeaders => "response.headers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AddRouteRequestRouteRouteTransformType? ToEnum(string value)
        {
            return value switch
            {
                "request.headers" => AddRouteRequestRouteRouteTransformType.RequestHeaders,
                "request.query" => AddRouteRequestRouteRouteTransformType.RequestQuery,
                "response.headers" => AddRouteRequestRouteRouteTransformType.ResponseHeaders,
                _ => null,
            };
        }
    }
}