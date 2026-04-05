
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum StageRoutesRequestRouteRouteMissingItemType
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
    public static class StageRoutesRequestRouteRouteMissingItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StageRoutesRequestRouteRouteMissingItemType value)
        {
            return value switch
            {
                StageRoutesRequestRouteRouteMissingItemType.Cookie => "cookie",
                StageRoutesRequestRouteRouteMissingItemType.Header => "header",
                StageRoutesRequestRouteRouteMissingItemType.Host => "host",
                StageRoutesRequestRouteRouteMissingItemType.Query => "query",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StageRoutesRequestRouteRouteMissingItemType? ToEnum(string value)
        {
            return value switch
            {
                "cookie" => StageRoutesRequestRouteRouteMissingItemType.Cookie,
                "header" => StageRoutesRequestRouteRouteMissingItemType.Header,
                "host" => StageRoutesRequestRouteRouteMissingItemType.Host,
                "query" => StageRoutesRequestRouteRouteMissingItemType.Query,
                _ => null,
            };
        }
    }
}