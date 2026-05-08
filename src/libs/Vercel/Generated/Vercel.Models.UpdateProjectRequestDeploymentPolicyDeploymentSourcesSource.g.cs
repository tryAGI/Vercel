
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
        Api,
        /// <summary>
        /// 
        /// </summary>
        Cli,
        /// <summary>
        /// 
        /// </summary>
        Git,
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
                UpdateProjectRequestDeploymentPolicyDeploymentSourcesSource.Api => "api",
                UpdateProjectRequestDeploymentPolicyDeploymentSourcesSource.Cli => "cli",
                UpdateProjectRequestDeploymentPolicyDeploymentSourcesSource.Git => "git",
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
                "api" => UpdateProjectRequestDeploymentPolicyDeploymentSourcesSource.Api,
                "cli" => UpdateProjectRequestDeploymentPolicyDeploymentSourcesSource.Cli,
                "git" => UpdateProjectRequestDeploymentPolicyDeploymentSourcesSource.Git,
                _ => null,
            };
        }
    }
}