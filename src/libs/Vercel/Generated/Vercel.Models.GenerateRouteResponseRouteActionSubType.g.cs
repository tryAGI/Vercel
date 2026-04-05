
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GenerateRouteResponseRouteActionSubType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseHeaders,
        /// <summary>
        /// 
        /// </summary>
        TransformRequestHeader,
        /// <summary>
        /// 
        /// </summary>
        TransformRequestQuery,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerateRouteResponseRouteActionSubTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerateRouteResponseRouteActionSubType value)
        {
            return value switch
            {
                GenerateRouteResponseRouteActionSubType.ResponseHeaders => "response-headers",
                GenerateRouteResponseRouteActionSubType.TransformRequestHeader => "transform-request-header",
                GenerateRouteResponseRouteActionSubType.TransformRequestQuery => "transform-request-query",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerateRouteResponseRouteActionSubType? ToEnum(string value)
        {
            return value switch
            {
                "response-headers" => GenerateRouteResponseRouteActionSubType.ResponseHeaders,
                "transform-request-header" => GenerateRouteResponseRouteActionSubType.TransformRequestHeader,
                "transform-request-query" => GenerateRouteResponseRouteActionSubType.TransformRequestQuery,
                _ => null,
            };
        }
    }
}