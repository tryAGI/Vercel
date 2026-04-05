
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CancelDeploymentResponseRouteVariant1MissingItemVariant2Type
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
    public static class CancelDeploymentResponseRouteVariant1MissingItemVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelDeploymentResponseRouteVariant1MissingItemVariant2Type value)
        {
            return value switch
            {
                CancelDeploymentResponseRouteVariant1MissingItemVariant2Type.Cookie => "cookie",
                CancelDeploymentResponseRouteVariant1MissingItemVariant2Type.Header => "header",
                CancelDeploymentResponseRouteVariant1MissingItemVariant2Type.Query => "query",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelDeploymentResponseRouteVariant1MissingItemVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "cookie" => CancelDeploymentResponseRouteVariant1MissingItemVariant2Type.Cookie,
                "header" => CancelDeploymentResponseRouteVariant1MissingItemVariant2Type.Header,
                "query" => CancelDeploymentResponseRouteVariant1MissingItemVariant2Type.Query,
                _ => null,
            };
        }
    }
}