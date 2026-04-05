
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant2ProjectAbuseBlockHistoryItemVariant4Action
    {
        /// <summary>
        /// 
        /// </summary>
        RouteUnblocked,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectsResponseVariant2ProjectAbuseBlockHistoryItemVariant4ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant2ProjectAbuseBlockHistoryItemVariant4Action value)
        {
            return value switch
            {
                GetProjectsResponseVariant2ProjectAbuseBlockHistoryItemVariant4Action.RouteUnblocked => "route-unblocked",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant2ProjectAbuseBlockHistoryItemVariant4Action? ToEnum(string value)
        {
            return value switch
            {
                "route-unblocked" => GetProjectsResponseVariant2ProjectAbuseBlockHistoryItemVariant4Action.RouteUnblocked,
                _ => null,
            };
        }
    }
}