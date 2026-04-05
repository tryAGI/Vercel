
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectAbuseBlockHistoryItemVariant4Action
    {
        /// <summary>
        /// 
        /// </summary>
        RouteUnblocked,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetMicrofrontendsInGroupResponseProjectAbuseBlockHistoryItemVariant4ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectAbuseBlockHistoryItemVariant4Action value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectAbuseBlockHistoryItemVariant4Action.RouteUnblocked => "route-unblocked",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectAbuseBlockHistoryItemVariant4Action? ToEnum(string value)
        {
            return value switch
            {
                "route-unblocked" => GetMicrofrontendsInGroupResponseProjectAbuseBlockHistoryItemVariant4Action.RouteUnblocked,
                _ => null,
            };
        }
    }
}