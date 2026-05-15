
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The mechanism that produced a deployment. - `'git'`: a Git provider webhook or other Git-source-driven deployment - `'cli'`: an upload via the Vercel CLI - `'api'`: a programmatic upload via the REST API
    /// </summary>
    public enum TeamDeploymentPolicyDeploymentSourcesSource
    {
        /// <summary>
        /// a Git provider webhook or other Git-source-driven deployment - `'cli'`: an upload via the Vercel CLI - `'api'`: a programmatic upload via the REST API
        /// </summary>
        Api,
        /// <summary>
        /// a Git provider webhook or other Git-source-driven deployment - `'cli'`: an upload via the Vercel CLI - `'api'`: a programmatic upload via the REST API
        /// </summary>
        Cli,
        /// <summary>
        /// a Git provider webhook or other Git-source-driven deployment - `'cli'`: an upload via the Vercel CLI - `'api'`: a programmatic upload via the REST API
        /// </summary>
        Git,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TeamDeploymentPolicyDeploymentSourcesSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamDeploymentPolicyDeploymentSourcesSource value)
        {
            return value switch
            {
                TeamDeploymentPolicyDeploymentSourcesSource.Api => "api",
                TeamDeploymentPolicyDeploymentSourcesSource.Cli => "cli",
                TeamDeploymentPolicyDeploymentSourcesSource.Git => "git",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamDeploymentPolicyDeploymentSourcesSource? ToEnum(string value)
        {
            return value switch
            {
                "api" => TeamDeploymentPolicyDeploymentSourcesSource.Api,
                "cli" => TeamDeploymentPolicyDeploymentSourcesSource.Cli,
                "git" => TeamDeploymentPolicyDeploymentSourcesSource.Git,
                _ => null,
            };
        }
    }
}