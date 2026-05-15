
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The mechanism that produced a deployment. - `'git'`: a Git provider webhook or other Git-source-driven deployment - `'cli'`: an upload via the Vercel CLI - `'api'`: a programmatic upload via the REST API
    /// </summary>
    public enum UpdateMicrofrontendsResponseDeploymentPolicyDeploymentSourcesSource
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
    public static class UpdateMicrofrontendsResponseDeploymentPolicyDeploymentSourcesSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseDeploymentPolicyDeploymentSourcesSource value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseDeploymentPolicyDeploymentSourcesSource.Api => "api",
                UpdateMicrofrontendsResponseDeploymentPolicyDeploymentSourcesSource.Cli => "cli",
                UpdateMicrofrontendsResponseDeploymentPolicyDeploymentSourcesSource.Git => "git",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseDeploymentPolicyDeploymentSourcesSource? ToEnum(string value)
        {
            return value switch
            {
                "api" => UpdateMicrofrontendsResponseDeploymentPolicyDeploymentSourcesSource.Api,
                "cli" => UpdateMicrofrontendsResponseDeploymentPolicyDeploymentSourcesSource.Cli,
                "git" => UpdateMicrofrontendsResponseDeploymentPolicyDeploymentSourcesSource.Git,
                _ => null,
            };
        }
    }
}