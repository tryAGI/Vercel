
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum EditRouteResponseRouteRouteTransformType
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
    public static class EditRouteResponseRouteRouteTransformTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditRouteResponseRouteRouteTransformType value)
        {
            return value switch
            {
                EditRouteResponseRouteRouteTransformType.RequestHeaders => "request.headers",
                EditRouteResponseRouteRouteTransformType.RequestQuery => "request.query",
                EditRouteResponseRouteRouteTransformType.ResponseHeaders => "response.headers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditRouteResponseRouteRouteTransformType? ToEnum(string value)
        {
            return value switch
            {
                "request.headers" => EditRouteResponseRouteRouteTransformType.RequestHeaders,
                "request.query" => EditRouteResponseRouteRouteTransformType.RequestQuery,
                "response.headers" => EditRouteResponseRouteRouteTransformType.ResponseHeaders,
                _ => null,
            };
        }
    }
}