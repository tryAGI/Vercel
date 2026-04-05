
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectResponseAbuseBlockAction
    {
        /// <summary>
        /// 
        /// </summary>
        Blocked,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateProjectResponseAbuseBlockActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseAbuseBlockAction value)
        {
            return value switch
            {
                UpdateProjectResponseAbuseBlockAction.Blocked => "blocked",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseAbuseBlockAction? ToEnum(string value)
        {
            return value switch
            {
                "blocked" => UpdateProjectResponseAbuseBlockAction.Blocked,
                _ => null,
            };
        }
    }
}