
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum AddRouteRequestRouteRouteMissingItemType
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
    public static class AddRouteRequestRouteRouteMissingItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AddRouteRequestRouteRouteMissingItemType value)
        {
            return value switch
            {
                AddRouteRequestRouteRouteMissingItemType.Cookie => "cookie",
                AddRouteRequestRouteRouteMissingItemType.Header => "header",
                AddRouteRequestRouteRouteMissingItemType.Host => "host",
                AddRouteRequestRouteRouteMissingItemType.Query => "query",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AddRouteRequestRouteRouteMissingItemType? ToEnum(string value)
        {
            return value switch
            {
                "cookie" => AddRouteRequestRouteRouteMissingItemType.Cookie,
                "header" => AddRouteRequestRouteRouteMissingItemType.Header,
                "host" => AddRouteRequestRouteRouteMissingItemType.Host,
                "query" => AddRouteRequestRouteRouteMissingItemType.Query,
                _ => null,
            };
        }
    }
}