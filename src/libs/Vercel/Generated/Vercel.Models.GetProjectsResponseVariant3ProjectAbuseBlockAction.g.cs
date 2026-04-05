
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectAbuseBlockAction
    {
        /// <summary>
        /// 
        /// </summary>
        Blocked,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectsResponseVariant3ProjectAbuseBlockActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectAbuseBlockAction value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectAbuseBlockAction.Blocked => "blocked",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectAbuseBlockAction? ToEnum(string value)
        {
            return value switch
            {
                "blocked" => GetProjectsResponseVariant3ProjectAbuseBlockAction.Blocked,
                _ => null,
            };
        }
    }
}