
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentResponseVariant2RouteVariant1MissingItemVariant2Type
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
    public static class CreateDeploymentResponseVariant2RouteVariant1MissingItemVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseVariant2RouteVariant1MissingItemVariant2Type value)
        {
            return value switch
            {
                CreateDeploymentResponseVariant2RouteVariant1MissingItemVariant2Type.Cookie => "cookie",
                CreateDeploymentResponseVariant2RouteVariant1MissingItemVariant2Type.Header => "header",
                CreateDeploymentResponseVariant2RouteVariant1MissingItemVariant2Type.Query => "query",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseVariant2RouteVariant1MissingItemVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "cookie" => CreateDeploymentResponseVariant2RouteVariant1MissingItemVariant2Type.Cookie,
                "header" => CreateDeploymentResponseVariant2RouteVariant1MissingItemVariant2Type.Header,
                "query" => CreateDeploymentResponseVariant2RouteVariant1MissingItemVariant2Type.Query,
                _ => null,
            };
        }
    }
}