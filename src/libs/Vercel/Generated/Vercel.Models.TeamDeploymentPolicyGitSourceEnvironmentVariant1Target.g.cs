
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum TeamDeploymentPolicyGitSourceEnvironmentVariant1Target
    {
        /// <summary>
        /// 
        /// </summary>
        Preview,
        /// <summary>
        /// 
        /// </summary>
        Production,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TeamDeploymentPolicyGitSourceEnvironmentVariant1TargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamDeploymentPolicyGitSourceEnvironmentVariant1Target value)
        {
            return value switch
            {
                TeamDeploymentPolicyGitSourceEnvironmentVariant1Target.Preview => "preview",
                TeamDeploymentPolicyGitSourceEnvironmentVariant1Target.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamDeploymentPolicyGitSourceEnvironmentVariant1Target? ToEnum(string value)
        {
            return value switch
            {
                "preview" => TeamDeploymentPolicyGitSourceEnvironmentVariant1Target.Preview,
                "production" => TeamDeploymentPolicyGitSourceEnvironmentVariant1Target.Production,
                _ => null,
            };
        }
    }
}