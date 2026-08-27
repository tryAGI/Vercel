
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CancelDeploymentResponseRouteVariant1TransformVariant1Type
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
    public static class CancelDeploymentResponseRouteVariant1TransformVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelDeploymentResponseRouteVariant1TransformVariant1Type value)
        {
            return value switch
            {
                CancelDeploymentResponseRouteVariant1TransformVariant1Type.RequestHeaders => "request.headers",
                CancelDeploymentResponseRouteVariant1TransformVariant1Type.RequestQuery => "request.query",
                CancelDeploymentResponseRouteVariant1TransformVariant1Type.ResponseHeaders => "response.headers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelDeploymentResponseRouteVariant1TransformVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "request.headers" => CancelDeploymentResponseRouteVariant1TransformVariant1Type.RequestHeaders,
                "request.query" => CancelDeploymentResponseRouteVariant1TransformVariant1Type.RequestQuery,
                "response.headers" => CancelDeploymentResponseRouteVariant1TransformVariant1Type.ResponseHeaders,
                _ => null,
            };
        }
    }
}