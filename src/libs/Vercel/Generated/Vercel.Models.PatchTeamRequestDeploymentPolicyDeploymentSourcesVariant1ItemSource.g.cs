
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchTeamRequestDeploymentPolicyDeploymentSourcesVariant1ItemSource
    {
        /// <summary>
        /// 
        /// </summary>
        Cli,
        /// <summary>
        /// 
        /// </summary>
        DeployHook,
        /// <summary>
        /// 
        /// </summary>
        Git,
        /// <summary>
        /// 
        /// </summary>
        Integration,
        /// <summary>
        /// 
        /// </summary>
        RestApi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchTeamRequestDeploymentPolicyDeploymentSourcesVariant1ItemSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchTeamRequestDeploymentPolicyDeploymentSourcesVariant1ItemSource value)
        {
            return value switch
            {
                PatchTeamRequestDeploymentPolicyDeploymentSourcesVariant1ItemSource.Cli => "cli",
                PatchTeamRequestDeploymentPolicyDeploymentSourcesVariant1ItemSource.DeployHook => "deploy-hook",
                PatchTeamRequestDeploymentPolicyDeploymentSourcesVariant1ItemSource.Git => "git",
                PatchTeamRequestDeploymentPolicyDeploymentSourcesVariant1ItemSource.Integration => "integration",
                PatchTeamRequestDeploymentPolicyDeploymentSourcesVariant1ItemSource.RestApi => "rest-api",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchTeamRequestDeploymentPolicyDeploymentSourcesVariant1ItemSource? ToEnum(string value)
        {
            return value switch
            {
                "cli" => PatchTeamRequestDeploymentPolicyDeploymentSourcesVariant1ItemSource.Cli,
                "deploy-hook" => PatchTeamRequestDeploymentPolicyDeploymentSourcesVariant1ItemSource.DeployHook,
                "git" => PatchTeamRequestDeploymentPolicyDeploymentSourcesVariant1ItemSource.Git,
                "integration" => PatchTeamRequestDeploymentPolicyDeploymentSourcesVariant1ItemSource.Integration,
                "rest-api" => PatchTeamRequestDeploymentPolicyDeploymentSourcesVariant1ItemSource.RestApi,
                _ => null,
            };
        }
    }
}