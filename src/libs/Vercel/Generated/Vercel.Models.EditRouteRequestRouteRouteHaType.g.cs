
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum EditRouteRequestRouteRouteHaType
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
    public static class EditRouteRequestRouteRouteHaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditRouteRequestRouteRouteHaType value)
        {
            return value switch
            {
                EditRouteRequestRouteRouteHaType.Cookie => "cookie",
                EditRouteRequestRouteRouteHaType.Header => "header",
                EditRouteRequestRouteRouteHaType.Host => "host",
                EditRouteRequestRouteRouteHaType.Query => "query",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditRouteRequestRouteRouteHaType? ToEnum(string value)
        {
            return value switch
            {
                "cookie" => EditRouteRequestRouteRouteHaType.Cookie,
                "header" => EditRouteRequestRouteRouteHaType.Header,
                "host" => EditRouteRequestRouteRouteHaType.Host,
                "query" => EditRouteRequestRouteRouteHaType.Query,
                _ => null,
            };
        }
    }
}