
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectResponseAbuseBlockHistoryItemVariant1Action
    {
        /// <summary>
        /// 
        /// </summary>
        Blocked,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateProjectResponseAbuseBlockHistoryItemVariant1ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseAbuseBlockHistoryItemVariant1Action value)
        {
            return value switch
            {
                UpdateProjectResponseAbuseBlockHistoryItemVariant1Action.Blocked => "blocked",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseAbuseBlockHistoryItemVariant1Action? ToEnum(string value)
        {
            return value switch
            {
                "blocked" => UpdateProjectResponseAbuseBlockHistoryItemVariant1Action.Blocked,
                _ => null,
            };
        }
    }
}