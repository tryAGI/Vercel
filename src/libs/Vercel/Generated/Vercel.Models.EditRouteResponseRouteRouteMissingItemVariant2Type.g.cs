
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum EditRouteResponseRouteRouteMissingItemVariant2Type
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
    public static class EditRouteResponseRouteRouteMissingItemVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditRouteResponseRouteRouteMissingItemVariant2Type value)
        {
            return value switch
            {
                EditRouteResponseRouteRouteMissingItemVariant2Type.Cookie => "cookie",
                EditRouteResponseRouteRouteMissingItemVariant2Type.Header => "header",
                EditRouteResponseRouteRouteMissingItemVariant2Type.Query => "query",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditRouteResponseRouteRouteMissingItemVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "cookie" => EditRouteResponseRouteRouteMissingItemVariant2Type.Cookie,
                "header" => EditRouteResponseRouteRouteMissingItemVariant2Type.Header,
                "query" => EditRouteResponseRouteRouteMissingItemVariant2Type.Query,
                _ => null,
            };
        }
    }
}