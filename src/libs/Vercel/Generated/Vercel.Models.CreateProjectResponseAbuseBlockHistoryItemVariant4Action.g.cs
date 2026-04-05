
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectResponseAbuseBlockHistoryItemVariant4Action
    {
        /// <summary>
        /// 
        /// </summary>
        RouteUnblocked,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateProjectResponseAbuseBlockHistoryItemVariant4ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseAbuseBlockHistoryItemVariant4Action value)
        {
            return value switch
            {
                CreateProjectResponseAbuseBlockHistoryItemVariant4Action.RouteUnblocked => "route-unblocked",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseAbuseBlockHistoryItemVariant4Action? ToEnum(string value)
        {
            return value switch
            {
                "route-unblocked" => CreateProjectResponseAbuseBlockHistoryItemVariant4Action.RouteUnblocked,
                _ => null,
            };
        }
    }
}