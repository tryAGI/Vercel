
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentResponseVariant1RouteVariant1TransformType
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
    public static class GetDeploymentResponseVariant1RouteVariant1TransformTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant1RouteVariant1TransformType value)
        {
            return value switch
            {
                GetDeploymentResponseVariant1RouteVariant1TransformType.RequestHeaders => "request.headers",
                GetDeploymentResponseVariant1RouteVariant1TransformType.RequestQuery => "request.query",
                GetDeploymentResponseVariant1RouteVariant1TransformType.ResponseHeaders => "response.headers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant1RouteVariant1TransformType? ToEnum(string value)
        {
            return value switch
            {
                "request.headers" => GetDeploymentResponseVariant1RouteVariant1TransformType.RequestHeaders,
                "request.query" => GetDeploymentResponseVariant1RouteVariant1TransformType.RequestQuery,
                "response.headers" => GetDeploymentResponseVariant1RouteVariant1TransformType.ResponseHeaders,
                _ => null,
            };
        }
    }
}