
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectResponseAbuseBlockHistoryItemVariant4Action
    {
        /// <summary>
        /// 
        /// </summary>
        RouteUnblocked,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectResponseAbuseBlockHistoryItemVariant4ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseAbuseBlockHistoryItemVariant4Action value)
        {
            return value switch
            {
                GetProjectResponseAbuseBlockHistoryItemVariant4Action.RouteUnblocked => "route-unblocked",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseAbuseBlockHistoryItemVariant4Action? ToEnum(string value)
        {
            return value switch
            {
                "route-unblocked" => GetProjectResponseAbuseBlockHistoryItemVariant4Action.RouteUnblocked,
                _ => null,
            };
        }
    }
}