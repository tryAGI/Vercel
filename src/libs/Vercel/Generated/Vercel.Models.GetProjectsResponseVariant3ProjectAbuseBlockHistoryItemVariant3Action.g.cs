
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectAbuseBlockHistoryItemVariant3Action
    {
        /// <summary>
        /// 
        /// </summary>
        RouteBlocked,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectsResponseVariant3ProjectAbuseBlockHistoryItemVariant3ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectAbuseBlockHistoryItemVariant3Action value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectAbuseBlockHistoryItemVariant3Action.RouteBlocked => "route-blocked",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectAbuseBlockHistoryItemVariant3Action? ToEnum(string value)
        {
            return value switch
            {
                "route-blocked" => GetProjectsResponseVariant3ProjectAbuseBlockHistoryItemVariant3Action.RouteBlocked,
                _ => null,
            };
        }
    }
}