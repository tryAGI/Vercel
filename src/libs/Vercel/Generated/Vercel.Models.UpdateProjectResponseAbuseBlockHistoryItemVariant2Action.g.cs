
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectResponseAbuseBlockHistoryItemVariant2Action
    {
        /// <summary>
        /// 
        /// </summary>
        Unblocked,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateProjectResponseAbuseBlockHistoryItemVariant2ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseAbuseBlockHistoryItemVariant2Action value)
        {
            return value switch
            {
                UpdateProjectResponseAbuseBlockHistoryItemVariant2Action.Unblocked => "unblocked",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseAbuseBlockHistoryItemVariant2Action? ToEnum(string value)
        {
            return value switch
            {
                "unblocked" => UpdateProjectResponseAbuseBlockHistoryItemVariant2Action.Unblocked,
                _ => null,
            };
        }
    }
}