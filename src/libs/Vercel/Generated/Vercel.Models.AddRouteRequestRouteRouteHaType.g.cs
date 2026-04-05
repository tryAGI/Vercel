
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum AddRouteRequestRouteRouteHaType
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
    public static class AddRouteRequestRouteRouteHaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AddRouteRequestRouteRouteHaType value)
        {
            return value switch
            {
                AddRouteRequestRouteRouteHaType.Cookie => "cookie",
                AddRouteRequestRouteRouteHaType.Header => "header",
                AddRouteRequestRouteRouteHaType.Host => "host",
                AddRouteRequestRouteRouteHaType.Query => "query",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AddRouteRequestRouteRouteHaType? ToEnum(string value)
        {
            return value switch
            {
                "cookie" => AddRouteRequestRouteRouteHaType.Cookie,
                "header" => AddRouteRequestRouteRouteHaType.Header,
                "host" => AddRouteRequestRouteRouteHaType.Host,
                "query" => AddRouteRequestRouteRouteHaType.Query,
                _ => null,
            };
        }
    }
}