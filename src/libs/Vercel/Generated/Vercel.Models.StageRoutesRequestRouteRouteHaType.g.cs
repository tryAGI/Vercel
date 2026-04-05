
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum StageRoutesRequestRouteRouteHaType
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
    public static class StageRoutesRequestRouteRouteHaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StageRoutesRequestRouteRouteHaType value)
        {
            return value switch
            {
                StageRoutesRequestRouteRouteHaType.Cookie => "cookie",
                StageRoutesRequestRouteRouteHaType.Header => "header",
                StageRoutesRequestRouteRouteHaType.Host => "host",
                StageRoutesRequestRouteRouteHaType.Query => "query",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StageRoutesRequestRouteRouteHaType? ToEnum(string value)
        {
            return value switch
            {
                "cookie" => StageRoutesRequestRouteRouteHaType.Cookie,
                "header" => StageRoutesRequestRouteRouteHaType.Header,
                "host" => StageRoutesRequestRouteRouteHaType.Host,
                "query" => StageRoutesRequestRouteRouteHaType.Query,
                _ => null,
            };
        }
    }
}