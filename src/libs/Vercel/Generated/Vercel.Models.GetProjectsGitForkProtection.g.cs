
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Specifies whether PRs from Git forks should require a team member's authorization before it can be deployed<br/>
    /// Example: 1
    /// </summary>
    public enum GetProjectsGitForkProtection
    {
        /// <summary>
        /// 
        /// </summary>
        x0,
        /// <summary>
        /// 
        /// </summary>
        x1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectsGitForkProtectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsGitForkProtection value)
        {
            return value switch
            {
                GetProjectsGitForkProtection.x0 => "0",
                GetProjectsGitForkProtection.x1 => "1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsGitForkProtection? ToEnum(string value)
        {
            return value switch
            {
                "0" => GetProjectsGitForkProtection.x0,
                "1" => GetProjectsGitForkProtection.x1,
                _ => null,
            };
        }
    }
}