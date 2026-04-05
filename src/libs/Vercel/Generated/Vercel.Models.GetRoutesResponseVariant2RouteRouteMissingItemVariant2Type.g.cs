
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetRoutesResponseVariant2RouteRouteMissingItemVariant2Type
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
    public static class GetRoutesResponseVariant2RouteRouteMissingItemVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRoutesResponseVariant2RouteRouteMissingItemVariant2Type value)
        {
            return value switch
            {
                GetRoutesResponseVariant2RouteRouteMissingItemVariant2Type.Cookie => "cookie",
                GetRoutesResponseVariant2RouteRouteMissingItemVariant2Type.Header => "header",
                GetRoutesResponseVariant2RouteRouteMissingItemVariant2Type.Query => "query",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRoutesResponseVariant2RouteRouteMissingItemVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "cookie" => GetRoutesResponseVariant2RouteRouteMissingItemVariant2Type.Cookie,
                "header" => GetRoutesResponseVariant2RouteRouteMissingItemVariant2Type.Header,
                "query" => GetRoutesResponseVariant2RouteRouteMissingItemVariant2Type.Query,
                _ => null,
            };
        }
    }
}