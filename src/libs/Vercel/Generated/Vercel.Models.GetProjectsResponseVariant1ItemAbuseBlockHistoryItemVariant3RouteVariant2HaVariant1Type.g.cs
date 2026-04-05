
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant1ItemAbuseBlockHistoryItemVariant3RouteVariant2HaVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Header,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectsResponseVariant1ItemAbuseBlockHistoryItemVariant3RouteVariant2HaVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant1ItemAbuseBlockHistoryItemVariant3RouteVariant2HaVariant1Type value)
        {
            return value switch
            {
                GetProjectsResponseVariant1ItemAbuseBlockHistoryItemVariant3RouteVariant2HaVariant1Type.Header => "header",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant1ItemAbuseBlockHistoryItemVariant3RouteVariant2HaVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "header" => GetProjectsResponseVariant1ItemAbuseBlockHistoryItemVariant3RouteVariant2HaVariant1Type.Header,
                _ => null,
            };
        }
    }
}