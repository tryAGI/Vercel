
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentResponseVariant1ServiceVariant2RouteVariant1MissingItemVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Cookie,
        /// <summary>
        /// 
        /// </summary>
        Header,
        /// <summary>
        /// 
        /// </summary>
        Query,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDeploymentResponseVariant1ServiceVariant2RouteVariant1MissingItemVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant1ServiceVariant2RouteVariant1MissingItemVariant2Type value)
        {
            return value switch
            {
                GetDeploymentResponseVariant1ServiceVariant2RouteVariant1MissingItemVariant2Type.Cookie => "cookie",
                GetDeploymentResponseVariant1ServiceVariant2RouteVariant1MissingItemVariant2Type.Header => "header",
                GetDeploymentResponseVariant1ServiceVariant2RouteVariant1MissingItemVariant2Type.Query => "query",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant1ServiceVariant2RouteVariant1MissingItemVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "cookie" => GetDeploymentResponseVariant1ServiceVariant2RouteVariant1MissingItemVariant2Type.Cookie,
                "header" => GetDeploymentResponseVariant1ServiceVariant2RouteVariant1MissingItemVariant2Type.Header,
                "query" => GetDeploymentResponseVariant1ServiceVariant2RouteVariant1MissingItemVariant2Type.Query,
                _ => null,
            };
        }
    }
}