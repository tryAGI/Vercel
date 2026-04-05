
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentResponseVariant1RouteVariant1HaVariant2Type
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
    public static class GetDeploymentResponseVariant1RouteVariant1HaVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant1RouteVariant1HaVariant2Type value)
        {
            return value switch
            {
                GetDeploymentResponseVariant1RouteVariant1HaVariant2Type.Cookie => "cookie",
                GetDeploymentResponseVariant1RouteVariant1HaVariant2Type.Header => "header",
                GetDeploymentResponseVariant1RouteVariant1HaVariant2Type.Query => "query",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant1RouteVariant1HaVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "cookie" => GetDeploymentResponseVariant1RouteVariant1HaVariant2Type.Cookie,
                "header" => GetDeploymentResponseVariant1RouteVariant1HaVariant2Type.Header,
                "query" => GetDeploymentResponseVariant1RouteVariant1HaVariant2Type.Query,
                _ => null,
            };
        }
    }
}