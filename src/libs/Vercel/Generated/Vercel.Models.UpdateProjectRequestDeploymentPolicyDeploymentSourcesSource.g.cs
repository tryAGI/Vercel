
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectRequestDeploymentPolicyDeploymentSourcesSource
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
    public static class UpdateProjectRequestDeploymentPolicyDeploymentSourcesSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectRequestDeploymentPolicyDeploymentSourcesSource value)
        {
            return value switch
            {
                UpdateProjectRequestDeploymentPolicyDeploymentSourcesSource.Cli => "cli",
                UpdateProjectRequestDeploymentPolicyDeploymentSourcesSource.DeployHook => "deploy-hook",
                UpdateProjectRequestDeploymentPolicyDeploymentSourcesSource.Git => "git",
                UpdateProjectRequestDeploymentPolicyDeploymentSourcesSource.Integration => "integration",
                UpdateProjectRequestDeploymentPolicyDeploymentSourcesSource.RestApi => "rest-api",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectRequestDeploymentPolicyDeploymentSourcesSource? ToEnum(string value)
        {
            return value switch
            {
                "cli" => UpdateProjectRequestDeploymentPolicyDeploymentSourcesSource.Cli,
                "deploy-hook" => UpdateProjectRequestDeploymentPolicyDeploymentSourcesSource.DeployHook,
                "git" => UpdateProjectRequestDeploymentPolicyDeploymentSourcesSource.Git,
                "integration" => UpdateProjectRequestDeploymentPolicyDeploymentSourcesSource.Integration,
                "rest-api" => UpdateProjectRequestDeploymentPolicyDeploymentSourcesSource.RestApi,
                _ => null,
            };
        }
    }
}