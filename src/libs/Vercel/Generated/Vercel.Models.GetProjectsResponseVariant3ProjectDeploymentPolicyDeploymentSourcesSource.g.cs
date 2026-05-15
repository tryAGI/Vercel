
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The mechanism that produced a deployment. - `'git'`: a Git provider webhook or other Git-source-driven deployment - `'cli'`: an upload via the Vercel CLI - `'api'`: a programmatic upload via the REST API
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectDeploymentPolicyDeploymentSourcesSource
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
    public static class GetProjectsResponseVariant3ProjectDeploymentPolicyDeploymentSourcesSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectDeploymentPolicyDeploymentSourcesSource value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectDeploymentPolicyDeploymentSourcesSource.Api => "api",
                GetProjectsResponseVariant3ProjectDeploymentPolicyDeploymentSourcesSource.Cli => "cli",
                GetProjectsResponseVariant3ProjectDeploymentPolicyDeploymentSourcesSource.Git => "git",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectDeploymentPolicyDeploymentSourcesSource? ToEnum(string value)
        {
            return value switch
            {
                "api" => GetProjectsResponseVariant3ProjectDeploymentPolicyDeploymentSourcesSource.Api,
                "cli" => GetProjectsResponseVariant3ProjectDeploymentPolicyDeploymentSourcesSource.Cli,
                "git" => GetProjectsResponseVariant3ProjectDeploymentPolicyDeploymentSourcesSource.Git,
                _ => null,
            };
        }
    }
}