
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectAbuseBlockHistoryItemVariant3RouteVariant2HaVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Host,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetMicrofrontendsInGroupResponseProjectAbuseBlockHistoryItemVariant3RouteVariant2HaVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectAbuseBlockHistoryItemVariant3RouteVariant2HaVariant2Type value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectAbuseBlockHistoryItemVariant3RouteVariant2HaVariant2Type.Host => "host",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectAbuseBlockHistoryItemVariant3RouteVariant2HaVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "host" => GetMicrofrontendsInGroupResponseProjectAbuseBlockHistoryItemVariant3RouteVariant2HaVariant2Type.Host,
                _ => null,
            };
        }
    }
}