
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentResponseRouteVariant1MissingItemVariant2Type
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
    public static class CreateDeploymentResponseRouteVariant1MissingItemVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseRouteVariant1MissingItemVariant2Type value)
        {
            return value switch
            {
                CreateDeploymentResponseRouteVariant1MissingItemVariant2Type.Cookie => "cookie",
                CreateDeploymentResponseRouteVariant1MissingItemVariant2Type.Header => "header",
                CreateDeploymentResponseRouteVariant1MissingItemVariant2Type.Query => "query",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseRouteVariant1MissingItemVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "cookie" => CreateDeploymentResponseRouteVariant1MissingItemVariant2Type.Cookie,
                "header" => CreateDeploymentResponseRouteVariant1MissingItemVariant2Type.Header,
                "query" => CreateDeploymentResponseRouteVariant1MissingItemVariant2Type.Query,
                _ => null,
            };
        }
    }
}