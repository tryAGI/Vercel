
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentResponseRouteVariant1TransformVariant1Type
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
    public static class CreateDeploymentResponseRouteVariant1TransformVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseRouteVariant1TransformVariant1Type value)
        {
            return value switch
            {
                CreateDeploymentResponseRouteVariant1TransformVariant1Type.RequestHeaders => "request.headers",
                CreateDeploymentResponseRouteVariant1TransformVariant1Type.RequestQuery => "request.query",
                CreateDeploymentResponseRouteVariant1TransformVariant1Type.ResponseHeaders => "response.headers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseRouteVariant1TransformVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "request.headers" => CreateDeploymentResponseRouteVariant1TransformVariant1Type.RequestHeaders,
                "request.query" => CreateDeploymentResponseRouteVariant1TransformVariant1Type.RequestQuery,
                "response.headers" => CreateDeploymentResponseRouteVariant1TransformVariant1Type.ResponseHeaders,
                _ => null,
            };
        }
    }
}