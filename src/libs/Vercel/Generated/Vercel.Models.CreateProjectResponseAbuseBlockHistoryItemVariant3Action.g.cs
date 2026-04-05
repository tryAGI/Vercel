
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectResponseAbuseBlockHistoryItemVariant3Action
    {
        /// <summary>
        /// 
        /// </summary>
        RouteBlocked,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateProjectResponseAbuseBlockHistoryItemVariant3ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseAbuseBlockHistoryItemVariant3Action value)
        {
            return value switch
            {
                CreateProjectResponseAbuseBlockHistoryItemVariant3Action.RouteBlocked => "route-blocked",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseAbuseBlockHistoryItemVariant3Action? ToEnum(string value)
        {
            return value switch
            {
                "route-blocked" => CreateProjectResponseAbuseBlockHistoryItemVariant3Action.RouteBlocked,
                _ => null,
            };
        }
    }
}