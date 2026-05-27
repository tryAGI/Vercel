
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchTeamRequestDeploymentPolicyDeploymentSourcesEnvironmentVariant1Target
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
    public static class PatchTeamRequestDeploymentPolicyDeploymentSourcesEnvironmentVariant1TargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchTeamRequestDeploymentPolicyDeploymentSourcesEnvironmentVariant1Target value)
        {
            return value switch
            {
                PatchTeamRequestDeploymentPolicyDeploymentSourcesEnvironmentVariant1Target.Preview => "preview",
                PatchTeamRequestDeploymentPolicyDeploymentSourcesEnvironmentVariant1Target.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchTeamRequestDeploymentPolicyDeploymentSourcesEnvironmentVariant1Target? ToEnum(string value)
        {
            return value switch
            {
                "preview" => PatchTeamRequestDeploymentPolicyDeploymentSourcesEnvironmentVariant1Target.Preview,
                "production" => PatchTeamRequestDeploymentPolicyDeploymentSourcesEnvironmentVariant1Target.Production,
                _ => null,
            };
        }
    }
}