
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentResponseRouteVariant1TransformType
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
    public static class CreateDeploymentResponseRouteVariant1TransformTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseRouteVariant1TransformType value)
        {
            return value switch
            {
                CreateDeploymentResponseRouteVariant1TransformType.RequestHeaders => "request.headers",
                CreateDeploymentResponseRouteVariant1TransformType.RequestQuery => "request.query",
                CreateDeploymentResponseRouteVariant1TransformType.ResponseHeaders => "response.headers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseRouteVariant1TransformType? ToEnum(string value)
        {
            return value switch
            {
                "request.headers" => CreateDeploymentResponseRouteVariant1TransformType.RequestHeaders,
                "request.query" => CreateDeploymentResponseRouteVariant1TransformType.RequestQuery,
                "response.headers" => CreateDeploymentResponseRouteVariant1TransformType.ResponseHeaders,
                _ => null,
            };
        }
    }
}