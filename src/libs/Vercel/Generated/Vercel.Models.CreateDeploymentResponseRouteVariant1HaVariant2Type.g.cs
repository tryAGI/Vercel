
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentResponseRouteVariant1HaVariant2Type
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
    public static class CreateDeploymentResponseRouteVariant1HaVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseRouteVariant1HaVariant2Type value)
        {
            return value switch
            {
                CreateDeploymentResponseRouteVariant1HaVariant2Type.Cookie => "cookie",
                CreateDeploymentResponseRouteVariant1HaVariant2Type.Header => "header",
                CreateDeploymentResponseRouteVariant1HaVariant2Type.Query => "query",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseRouteVariant1HaVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "cookie" => CreateDeploymentResponseRouteVariant1HaVariant2Type.Cookie,
                "header" => CreateDeploymentResponseRouteVariant1HaVariant2Type.Header,
                "query" => CreateDeploymentResponseRouteVariant1HaVariant2Type.Query,
                _ => null,
            };
        }
    }
}