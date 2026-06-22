
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CancelDeploymentResponseServiceVariant2RouteVariant1TransformType
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
    public static class CancelDeploymentResponseServiceVariant2RouteVariant1TransformTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelDeploymentResponseServiceVariant2RouteVariant1TransformType value)
        {
            return value switch
            {
                CancelDeploymentResponseServiceVariant2RouteVariant1TransformType.RequestHeaders => "request.headers",
                CancelDeploymentResponseServiceVariant2RouteVariant1TransformType.RequestQuery => "request.query",
                CancelDeploymentResponseServiceVariant2RouteVariant1TransformType.ResponseHeaders => "response.headers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelDeploymentResponseServiceVariant2RouteVariant1TransformType? ToEnum(string value)
        {
            return value switch
            {
                "request.headers" => CancelDeploymentResponseServiceVariant2RouteVariant1TransformType.RequestHeaders,
                "request.query" => CancelDeploymentResponseServiceVariant2RouteVariant1TransformType.RequestQuery,
                "response.headers" => CancelDeploymentResponseServiceVariant2RouteVariant1TransformType.ResponseHeaders,
                _ => null,
            };
        }
    }
}