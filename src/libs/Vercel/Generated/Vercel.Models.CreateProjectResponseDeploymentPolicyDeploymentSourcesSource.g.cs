
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The mechanism that produced a deployment. - `'git'`: a Git provider webhook or other Git-source-driven deployment - `'cli'`: an upload via the Vercel CLI - `'api'`: a programmatic upload via the REST API
    /// </summary>
    public enum CreateProjectResponseDeploymentPolicyDeploymentSourcesSource
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
    public static class CreateProjectResponseDeploymentPolicyDeploymentSourcesSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseDeploymentPolicyDeploymentSourcesSource value)
        {
            return value switch
            {
                CreateProjectResponseDeploymentPolicyDeploymentSourcesSource.Api => "api",
                CreateProjectResponseDeploymentPolicyDeploymentSourcesSource.Cli => "cli",
                CreateProjectResponseDeploymentPolicyDeploymentSourcesSource.Git => "git",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseDeploymentPolicyDeploymentSourcesSource? ToEnum(string value)
        {
            return value switch
            {
                "api" => CreateProjectResponseDeploymentPolicyDeploymentSourcesSource.Api,
                "cli" => CreateProjectResponseDeploymentPolicyDeploymentSourcesSource.Cli,
                "git" => CreateProjectResponseDeploymentPolicyDeploymentSourcesSource.Git,
                _ => null,
            };
        }
    }
}