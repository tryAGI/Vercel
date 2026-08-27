
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum PatchTeamRequestDeploymentPolicyGitSourcesVariant1ItemEnvironmentVariant1Target
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
    public static class PatchTeamRequestDeploymentPolicyGitSourcesVariant1ItemEnvironmentVariant1TargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchTeamRequestDeploymentPolicyGitSourcesVariant1ItemEnvironmentVariant1Target value)
        {
            return value switch
            {
                PatchTeamRequestDeploymentPolicyGitSourcesVariant1ItemEnvironmentVariant1Target.Preview => "preview",
                PatchTeamRequestDeploymentPolicyGitSourcesVariant1ItemEnvironmentVariant1Target.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchTeamRequestDeploymentPolicyGitSourcesVariant1ItemEnvironmentVariant1Target? ToEnum(string value)
        {
            return value switch
            {
                "preview" => PatchTeamRequestDeploymentPolicyGitSourcesVariant1ItemEnvironmentVariant1Target.Preview,
                "production" => PatchTeamRequestDeploymentPolicyGitSourcesVariant1ItemEnvironmentVariant1Target.Production,
                _ => null,
            };
        }
    }
}