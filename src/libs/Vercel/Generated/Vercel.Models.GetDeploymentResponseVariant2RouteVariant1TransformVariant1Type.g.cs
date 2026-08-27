
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetDeploymentResponseVariant2RouteVariant1TransformVariant1Type
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
    public static class GetDeploymentResponseVariant2RouteVariant1TransformVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant2RouteVariant1TransformVariant1Type value)
        {
            return value switch
            {
                GetDeploymentResponseVariant2RouteVariant1TransformVariant1Type.RequestHeaders => "request.headers",
                GetDeploymentResponseVariant2RouteVariant1TransformVariant1Type.RequestQuery => "request.query",
                GetDeploymentResponseVariant2RouteVariant1TransformVariant1Type.ResponseHeaders => "response.headers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant2RouteVariant1TransformVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "request.headers" => GetDeploymentResponseVariant2RouteVariant1TransformVariant1Type.RequestHeaders,
                "request.query" => GetDeploymentResponseVariant2RouteVariant1TransformVariant1Type.RequestQuery,
                "response.headers" => GetDeploymentResponseVariant2RouteVariant1TransformVariant1Type.ResponseHeaders,
                _ => null,
            };
        }
    }
}