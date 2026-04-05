
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum EditRouteRequestRouteRouteMissingItemType
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
        Host,
        /// <summary>
        /// 
        /// </summary>
        Query,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EditRouteRequestRouteRouteMissingItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditRouteRequestRouteRouteMissingItemType value)
        {
            return value switch
            {
                EditRouteRequestRouteRouteMissingItemType.Cookie => "cookie",
                EditRouteRequestRouteRouteMissingItemType.Header => "header",
                EditRouteRequestRouteRouteMissingItemType.Host => "host",
                EditRouteRequestRouteRouteMissingItemType.Query => "query",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditRouteRequestRouteRouteMissingItemType? ToEnum(string value)
        {
            return value switch
            {
                "cookie" => EditRouteRequestRouteRouteMissingItemType.Cookie,
                "header" => EditRouteRequestRouteRouteMissingItemType.Header,
                "host" => EditRouteRequestRouteRouteMissingItemType.Host,
                "query" => EditRouteRequestRouteRouteMissingItemType.Query,
                _ => null,
            };
        }
    }
}