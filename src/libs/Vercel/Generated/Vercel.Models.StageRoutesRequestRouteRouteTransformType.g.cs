
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum StageRoutesRequestRouteRouteTransformType
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
    public static class StageRoutesRequestRouteRouteTransformTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StageRoutesRequestRouteRouteTransformType value)
        {
            return value switch
            {
                StageRoutesRequestRouteRouteTransformType.RequestHeaders => "request.headers",
                StageRoutesRequestRouteRouteTransformType.RequestQuery => "request.query",
                StageRoutesRequestRouteRouteTransformType.ResponseHeaders => "response.headers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StageRoutesRequestRouteRouteTransformType? ToEnum(string value)
        {
            return value switch
            {
                "request.headers" => StageRoutesRequestRouteRouteTransformType.RequestHeaders,
                "request.query" => StageRoutesRequestRouteRouteTransformType.RequestQuery,
                "response.headers" => StageRoutesRequestRouteRouteTransformType.ResponseHeaders,
                _ => null,
            };
        }
    }
}