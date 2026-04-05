
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectCheckResponseSourceVariant3Kind
    {
        /// <summary>
        /// 
        /// </summary>
        GitProvider,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateProjectCheckResponseSourceVariant3KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectCheckResponseSourceVariant3Kind value)
        {
            return value switch
            {
                UpdateProjectCheckResponseSourceVariant3Kind.GitProvider => "git-provider",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectCheckResponseSourceVariant3Kind? ToEnum(string value)
        {
            return value switch
            {
                "git-provider" => UpdateProjectCheckResponseSourceVariant3Kind.GitProvider,
                _ => null,
            };
        }
    }
}