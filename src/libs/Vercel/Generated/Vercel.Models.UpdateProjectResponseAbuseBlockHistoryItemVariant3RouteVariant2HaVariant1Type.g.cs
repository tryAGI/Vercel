
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectResponseAbuseBlockHistoryItemVariant3RouteVariant2HaVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Header,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateProjectResponseAbuseBlockHistoryItemVariant3RouteVariant2HaVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseAbuseBlockHistoryItemVariant3RouteVariant2HaVariant1Type value)
        {
            return value switch
            {
                UpdateProjectResponseAbuseBlockHistoryItemVariant3RouteVariant2HaVariant1Type.Header => "header",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseAbuseBlockHistoryItemVariant3RouteVariant2HaVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "header" => UpdateProjectResponseAbuseBlockHistoryItemVariant3RouteVariant2HaVariant1Type.Header,
                _ => null,
            };
        }
    }
}