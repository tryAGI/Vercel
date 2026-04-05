
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectResponseAbuseBlockHistoryItemVariant3Action
    {
        /// <summary>
        /// 
        /// </summary>
        RouteBlocked,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectResponseAbuseBlockHistoryItemVariant3ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseAbuseBlockHistoryItemVariant3Action value)
        {
            return value switch
            {
                GetProjectResponseAbuseBlockHistoryItemVariant3Action.RouteBlocked => "route-blocked",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseAbuseBlockHistoryItemVariant3Action? ToEnum(string value)
        {
            return value switch
            {
                "route-blocked" => GetProjectResponseAbuseBlockHistoryItemVariant3Action.RouteBlocked,
                _ => null,
            };
        }
    }
}