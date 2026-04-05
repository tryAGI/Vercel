
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CancelDeploymentResponseRouteVariant1TransformType
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
    public static class CancelDeploymentResponseRouteVariant1TransformTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelDeploymentResponseRouteVariant1TransformType value)
        {
            return value switch
            {
                CancelDeploymentResponseRouteVariant1TransformType.RequestHeaders => "request.headers",
                CancelDeploymentResponseRouteVariant1TransformType.RequestQuery => "request.query",
                CancelDeploymentResponseRouteVariant1TransformType.ResponseHeaders => "response.headers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelDeploymentResponseRouteVariant1TransformType? ToEnum(string value)
        {
            return value switch
            {
                "request.headers" => CancelDeploymentResponseRouteVariant1TransformType.RequestHeaders,
                "request.query" => CancelDeploymentResponseRouteVariant1TransformType.RequestQuery,
                "response.headers" => CancelDeploymentResponseRouteVariant1TransformType.ResponseHeaders,
                _ => null,
            };
        }
    }
}