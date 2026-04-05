
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectResponseAbuseBlockAction
    {
        /// <summary>
        /// 
        /// </summary>
        Blocked,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectResponseAbuseBlockActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseAbuseBlockAction value)
        {
            return value switch
            {
                GetProjectResponseAbuseBlockAction.Blocked => "blocked",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseAbuseBlockAction? ToEnum(string value)
        {
            return value switch
            {
                "blocked" => GetProjectResponseAbuseBlockAction.Blocked,
                _ => null,
            };
        }
    }
}