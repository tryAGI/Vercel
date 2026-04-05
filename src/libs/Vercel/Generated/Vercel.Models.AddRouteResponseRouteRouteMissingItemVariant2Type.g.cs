
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum AddRouteResponseRouteRouteMissingItemVariant2Type
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
    public static class AddRouteResponseRouteRouteMissingItemVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AddRouteResponseRouteRouteMissingItemVariant2Type value)
        {
            return value switch
            {
                AddRouteResponseRouteRouteMissingItemVariant2Type.Cookie => "cookie",
                AddRouteResponseRouteRouteMissingItemVariant2Type.Header => "header",
                AddRouteResponseRouteRouteMissingItemVariant2Type.Query => "query",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AddRouteResponseRouteRouteMissingItemVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "cookie" => AddRouteResponseRouteRouteMissingItemVariant2Type.Cookie,
                "header" => AddRouteResponseRouteRouteMissingItemVariant2Type.Header,
                "query" => AddRouteResponseRouteRouteMissingItemVariant2Type.Query,
                _ => null,
            };
        }
    }
}