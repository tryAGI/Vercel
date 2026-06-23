
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum EditRouteResponseRouteRouteTransformVariant1Type
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
    public static class EditRouteResponseRouteRouteTransformVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditRouteResponseRouteRouteTransformVariant1Type value)
        {
            return value switch
            {
                EditRouteResponseRouteRouteTransformVariant1Type.RequestHeaders => "request.headers",
                EditRouteResponseRouteRouteTransformVariant1Type.RequestQuery => "request.query",
                EditRouteResponseRouteRouteTransformVariant1Type.ResponseHeaders => "response.headers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditRouteResponseRouteRouteTransformVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "request.headers" => EditRouteResponseRouteRouteTransformVariant1Type.RequestHeaders,
                "request.query" => EditRouteResponseRouteRouteTransformVariant1Type.RequestQuery,
                "response.headers" => EditRouteResponseRouteRouteTransformVariant1Type.ResponseHeaders,
                _ => null,
            };
        }
    }
}