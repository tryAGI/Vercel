
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchTeamRequestDeploymentPolicyGitSourcesVariant1ItemEnvironmentVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Custom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchTeamRequestDeploymentPolicyGitSourcesVariant1ItemEnvironmentVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchTeamRequestDeploymentPolicyGitSourcesVariant1ItemEnvironmentVariant2Type value)
        {
            return value switch
            {
                PatchTeamRequestDeploymentPolicyGitSourcesVariant1ItemEnvironmentVariant2Type.Custom => "custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchTeamRequestDeploymentPolicyGitSourcesVariant1ItemEnvironmentVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "custom" => PatchTeamRequestDeploymentPolicyGitSourcesVariant1ItemEnvironmentVariant2Type.Custom,
                _ => null,
            };
        }
    }
}