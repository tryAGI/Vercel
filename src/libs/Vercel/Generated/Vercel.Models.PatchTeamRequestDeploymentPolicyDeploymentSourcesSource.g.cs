
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchTeamRequestDeploymentPolicyDeploymentSourcesSource
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
    public static class PatchTeamRequestDeploymentPolicyDeploymentSourcesSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchTeamRequestDeploymentPolicyDeploymentSourcesSource value)
        {
            return value switch
            {
                PatchTeamRequestDeploymentPolicyDeploymentSourcesSource.Cli => "cli",
                PatchTeamRequestDeploymentPolicyDeploymentSourcesSource.DeployHook => "deploy-hook",
                PatchTeamRequestDeploymentPolicyDeploymentSourcesSource.Git => "git",
                PatchTeamRequestDeploymentPolicyDeploymentSourcesSource.Integration => "integration",
                PatchTeamRequestDeploymentPolicyDeploymentSourcesSource.RestApi => "rest-api",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchTeamRequestDeploymentPolicyDeploymentSourcesSource? ToEnum(string value)
        {
            return value switch
            {
                "cli" => PatchTeamRequestDeploymentPolicyDeploymentSourcesSource.Cli,
                "deploy-hook" => PatchTeamRequestDeploymentPolicyDeploymentSourcesSource.DeployHook,
                "git" => PatchTeamRequestDeploymentPolicyDeploymentSourcesSource.Git,
                "integration" => PatchTeamRequestDeploymentPolicyDeploymentSourcesSource.Integration,
                "rest-api" => PatchTeamRequestDeploymentPolicyDeploymentSourcesSource.RestApi,
                _ => null,
            };
        }
    }
}