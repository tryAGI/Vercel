
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateProjectRequestDeploymentPolicyDeploymentSourcesVariant1ItemSource
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
        /// <summary>
        ///
        /// </summary>
        V0,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateProjectRequestDeploymentPolicyDeploymentSourcesVariant1ItemSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectRequestDeploymentPolicyDeploymentSourcesVariant1ItemSource value)
        {
            return value switch
            {
                UpdateProjectRequestDeploymentPolicyDeploymentSourcesVariant1ItemSource.Cli => "cli",
                UpdateProjectRequestDeploymentPolicyDeploymentSourcesVariant1ItemSource.DeployHook => "deploy-hook",
                UpdateProjectRequestDeploymentPolicyDeploymentSourcesVariant1ItemSource.Git => "git",
                UpdateProjectRequestDeploymentPolicyDeploymentSourcesVariant1ItemSource.Integration => "integration",
                UpdateProjectRequestDeploymentPolicyDeploymentSourcesVariant1ItemSource.RestApi => "rest-api",
                UpdateProjectRequestDeploymentPolicyDeploymentSourcesVariant1ItemSource.V0 => "v0",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectRequestDeploymentPolicyDeploymentSourcesVariant1ItemSource? ToEnum(string value)
        {
            return value switch
            {
                "cli" => UpdateProjectRequestDeploymentPolicyDeploymentSourcesVariant1ItemSource.Cli,
                "deploy-hook" => UpdateProjectRequestDeploymentPolicyDeploymentSourcesVariant1ItemSource.DeployHook,
                "git" => UpdateProjectRequestDeploymentPolicyDeploymentSourcesVariant1ItemSource.Git,
                "integration" => UpdateProjectRequestDeploymentPolicyDeploymentSourcesVariant1ItemSource.Integration,
                "rest-api" => UpdateProjectRequestDeploymentPolicyDeploymentSourcesVariant1ItemSource.RestApi,
                "v0" => UpdateProjectRequestDeploymentPolicyDeploymentSourcesVariant1ItemSource.V0,
                _ => null,
            };
        }
    }
}