
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchTeamRequestDeploymentPolicyGitSourcesEnvironmentVariant1Target
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
    public static class PatchTeamRequestDeploymentPolicyGitSourcesEnvironmentVariant1TargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchTeamRequestDeploymentPolicyGitSourcesEnvironmentVariant1Target value)
        {
            return value switch
            {
                PatchTeamRequestDeploymentPolicyGitSourcesEnvironmentVariant1Target.Preview => "preview",
                PatchTeamRequestDeploymentPolicyGitSourcesEnvironmentVariant1Target.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchTeamRequestDeploymentPolicyGitSourcesEnvironmentVariant1Target? ToEnum(string value)
        {
            return value switch
            {
                "preview" => PatchTeamRequestDeploymentPolicyGitSourcesEnvironmentVariant1Target.Preview,
                "production" => PatchTeamRequestDeploymentPolicyGitSourcesEnvironmentVariant1Target.Production,
                _ => null,
            };
        }
    }
}