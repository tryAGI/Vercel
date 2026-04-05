
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant1ItemAbuseBlockHistoryItemVariant4Action
    {
        /// <summary>
        /// 
        /// </summary>
        RouteUnblocked,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectsResponseVariant1ItemAbuseBlockHistoryItemVariant4ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant1ItemAbuseBlockHistoryItemVariant4Action value)
        {
            return value switch
            {
                GetProjectsResponseVariant1ItemAbuseBlockHistoryItemVariant4Action.RouteUnblocked => "route-unblocked",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant1ItemAbuseBlockHistoryItemVariant4Action? ToEnum(string value)
        {
            return value switch
            {
                "route-unblocked" => GetProjectsResponseVariant1ItemAbuseBlockHistoryItemVariant4Action.RouteUnblocked,
                _ => null,
            };
        }
    }
}