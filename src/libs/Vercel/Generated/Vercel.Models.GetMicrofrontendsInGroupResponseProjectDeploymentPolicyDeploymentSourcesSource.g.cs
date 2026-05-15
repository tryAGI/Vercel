
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The mechanism that produced a deployment. - `'git'`: a Git provider webhook or other Git-source-driven deployment - `'cli'`: an upload via the Vercel CLI - `'api'`: a programmatic upload via the REST API
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectDeploymentPolicyDeploymentSourcesSource
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
    public static class GetMicrofrontendsInGroupResponseProjectDeploymentPolicyDeploymentSourcesSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectDeploymentPolicyDeploymentSourcesSource value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectDeploymentPolicyDeploymentSourcesSource.Api => "api",
                GetMicrofrontendsInGroupResponseProjectDeploymentPolicyDeploymentSourcesSource.Cli => "cli",
                GetMicrofrontendsInGroupResponseProjectDeploymentPolicyDeploymentSourcesSource.Git => "git",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectDeploymentPolicyDeploymentSourcesSource? ToEnum(string value)
        {
            return value switch
            {
                "api" => GetMicrofrontendsInGroupResponseProjectDeploymentPolicyDeploymentSourcesSource.Api,
                "cli" => GetMicrofrontendsInGroupResponseProjectDeploymentPolicyDeploymentSourcesSource.Cli,
                "git" => GetMicrofrontendsInGroupResponseProjectDeploymentPolicyDeploymentSourcesSource.Git,
                _ => null,
            };
        }
    }
}