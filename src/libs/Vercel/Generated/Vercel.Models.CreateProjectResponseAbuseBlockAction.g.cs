
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectResponseAbuseBlockAction
    {
        /// <summary>
        /// 
        /// </summary>
        Blocked,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateProjectResponseAbuseBlockActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseAbuseBlockAction value)
        {
            return value switch
            {
                CreateProjectResponseAbuseBlockAction.Blocked => "blocked",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseAbuseBlockAction? ToEnum(string value)
        {
            return value switch
            {
                "blocked" => CreateProjectResponseAbuseBlockAction.Blocked,
                _ => null,
            };
        }
    }
}