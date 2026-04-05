
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum EditRouteResponseRouteRouteHaVariant2Type
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
    public static class EditRouteResponseRouteRouteHaVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditRouteResponseRouteRouteHaVariant2Type value)
        {
            return value switch
            {
                EditRouteResponseRouteRouteHaVariant2Type.Cookie => "cookie",
                EditRouteResponseRouteRouteHaVariant2Type.Header => "header",
                EditRouteResponseRouteRouteHaVariant2Type.Query => "query",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditRouteResponseRouteRouteHaVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "cookie" => EditRouteResponseRouteRouteHaVariant2Type.Cookie,
                "header" => EditRouteResponseRouteRouteHaVariant2Type.Header,
                "query" => EditRouteResponseRouteRouteHaVariant2Type.Query,
                _ => null,
            };
        }
    }
}