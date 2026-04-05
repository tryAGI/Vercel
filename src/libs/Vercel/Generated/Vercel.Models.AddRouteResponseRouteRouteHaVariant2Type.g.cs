
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum AddRouteResponseRouteRouteHaVariant2Type
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
    public static class AddRouteResponseRouteRouteHaVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AddRouteResponseRouteRouteHaVariant2Type value)
        {
            return value switch
            {
                AddRouteResponseRouteRouteHaVariant2Type.Cookie => "cookie",
                AddRouteResponseRouteRouteHaVariant2Type.Header => "header",
                AddRouteResponseRouteRouteHaVariant2Type.Query => "query",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AddRouteResponseRouteRouteHaVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "cookie" => AddRouteResponseRouteRouteHaVariant2Type.Cookie,
                "header" => AddRouteResponseRouteRouteHaVariant2Type.Header,
                "query" => AddRouteResponseRouteRouteHaVariant2Type.Query,
                _ => null,
            };
        }
    }
}