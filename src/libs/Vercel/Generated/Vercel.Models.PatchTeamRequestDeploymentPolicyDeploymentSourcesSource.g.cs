
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
    public static class PatchTeamRequestDeploymentPolicyDeploymentSourcesSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchTeamRequestDeploymentPolicyDeploymentSourcesSource value)
        {
            return value switch
            {
                PatchTeamRequestDeploymentPolicyDeploymentSourcesSource.Api => "api",
                PatchTeamRequestDeploymentPolicyDeploymentSourcesSource.Cli => "cli",
                PatchTeamRequestDeploymentPolicyDeploymentSourcesSource.Git => "git",
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
                "api" => PatchTeamRequestDeploymentPolicyDeploymentSourcesSource.Api,
                "cli" => PatchTeamRequestDeploymentPolicyDeploymentSourcesSource.Cli,
                "git" => PatchTeamRequestDeploymentPolicyDeploymentSourcesSource.Git,
                _ => null,
            };
        }
    }
}