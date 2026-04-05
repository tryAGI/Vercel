
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectResponseAbuseBlockHistoryItemVariant3Action
    {
        /// <summary>
        /// 
        /// </summary>
        RouteBlocked,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateProjectResponseAbuseBlockHistoryItemVariant3ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseAbuseBlockHistoryItemVariant3Action value)
        {
            return value switch
            {
                UpdateProjectResponseAbuseBlockHistoryItemVariant3Action.RouteBlocked => "route-blocked",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseAbuseBlockHistoryItemVariant3Action? ToEnum(string value)
        {
            return value switch
            {
                "route-blocked" => UpdateProjectResponseAbuseBlockHistoryItemVariant3Action.RouteBlocked,
                _ => null,
            };
        }
    }
}