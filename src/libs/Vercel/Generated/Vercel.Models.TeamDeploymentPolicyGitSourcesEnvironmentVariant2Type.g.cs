
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum TeamDeploymentPolicyGitSourcesEnvironmentVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Custom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TeamDeploymentPolicyGitSourcesEnvironmentVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamDeploymentPolicyGitSourcesEnvironmentVariant2Type value)
        {
            return value switch
            {
                TeamDeploymentPolicyGitSourcesEnvironmentVariant2Type.Custom => "custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamDeploymentPolicyGitSourcesEnvironmentVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "custom" => TeamDeploymentPolicyGitSourcesEnvironmentVariant2Type.Custom,
                _ => null,
            };
        }
    }
}