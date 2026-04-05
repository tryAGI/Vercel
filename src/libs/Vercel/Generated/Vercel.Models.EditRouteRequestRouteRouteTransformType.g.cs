
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum EditRouteRequestRouteRouteTransformType
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
    public static class EditRouteRequestRouteRouteTransformTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditRouteRequestRouteRouteTransformType value)
        {
            return value switch
            {
                EditRouteRequestRouteRouteTransformType.RequestHeaders => "request.headers",
                EditRouteRequestRouteRouteTransformType.RequestQuery => "request.query",
                EditRouteRequestRouteRouteTransformType.ResponseHeaders => "response.headers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditRouteRequestRouteRouteTransformType? ToEnum(string value)
        {
            return value switch
            {
                "request.headers" => EditRouteRequestRouteRouteTransformType.RequestHeaders,
                "request.query" => EditRouteRequestRouteRouteTransformType.RequestQuery,
                "response.headers" => EditRouteRequestRouteRouteTransformType.ResponseHeaders,
                _ => null,
            };
        }
    }
}