
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The mechanism that produced a deployment. - `'git'`: a Git provider webhook (GitHub / GitLab / Bitbucket) - `'cli'`: an upload via the Vercel CLI - `'rest-api'`: a first-party REST API upload — a user or team token POSTing directly. Does NOT cover deploy-hook URLs or OAuth2 integration tokens; those are their own sources. - `'deploy-hook'`: a trigger via a project deploy-hook URL. The URL itself is the credential, so the request has no authenticated principal. - `'integration'`: an OAuth2 actor — a Marketplace integration token, a Vercel App token, or a user-delegated OAuth flow where an integration is acting on a user's behalf. Every deployment classifies to exactly one source; the values are mutually exclusive. See `classify-source` (in the policy package's consumers) for the canonical classification order. The split between `'rest-api'` and `'integration'` is intentional so a team can permit their own automation while blocking third-party integrators — or vice versa.
    /// </summary>
    public enum CreateProjectResponseDeploymentPolicyDeploymentSourcesSource
    {
        /// <summary>
        /// a Git provider webhook (GitHub / GitLab / Bitbucket) - `'cli'`: an upload via the Vercel CLI - `'rest-api'`: a first-party REST API upload — a user or team token POSTing directly. Does NOT cover deploy-hook URLs or OAuth2 integration tokens; those are their own sources. - `'deploy-hook'`: a trigger via a project deploy-hook URL. The URL itself is the credential, so the request has no authenticated principal. - `'integration'`: an OAuth2 actor — a Marketplace integration token, a Vercel App token, or a user-delegated OAuth flow where an integration is acting on a user's behalf. Every deployment classifies to exactly one source; the values are mutually exclusive. See `classify-source` (in the policy package's consumers) for the canonical classification order. The split between `'rest-api'` and `'integration'` is intentional so a team can permit their own automation while blocking third-party integrators — or vice versa.
        /// </summary>
        Cli,
        /// <summary>
        /// a Git provider webhook (GitHub / GitLab / Bitbucket) - `'cli'`: an upload via the Vercel CLI - `'rest-api'`: a first-party REST API upload — a user or team token POSTing directly. Does NOT cover deploy-hook URLs or OAuth2 integration tokens; those are their own sources. - `'deploy-hook'`: a trigger via a project deploy-hook URL. The URL itself is the credential, so the request has no authenticated principal. - `'integration'`: an OAuth2 actor — a Marketplace integration token, a Vercel App token, or a user-delegated OAuth flow where an integration is acting on a user's behalf. Every deployment classifies to exactly one source; the values are mutually exclusive. See `classify-source` (in the policy package's consumers) for the canonical classification order. The split between `'rest-api'` and `'integration'` is intentional so a team can permit their own automation while blocking third-party integrators — or vice versa.
        /// </summary>
        DeployHook,
        /// <summary>
        /// a Git provider webhook (GitHub / GitLab / Bitbucket) - `'cli'`: an upload via the Vercel CLI - `'rest-api'`: a first-party REST API upload — a user or team token POSTing directly. Does NOT cover deploy-hook URLs or OAuth2 integration tokens; those are their own sources. - `'deploy-hook'`: a trigger via a project deploy-hook URL. The URL itself is the credential, so the request has no authenticated principal. - `'integration'`: an OAuth2 actor — a Marketplace integration token, a Vercel App token, or a user-delegated OAuth flow where an integration is acting on a user's behalf. Every deployment classifies to exactly one source; the values are mutually exclusive. See `classify-source` (in the policy package's consumers) for the canonical classification order. The split between `'rest-api'` and `'integration'` is intentional so a team can permit their own automation while blocking third-party integrators — or vice versa.
        /// </summary>
        Git,
        /// <summary>
        /// a Git provider webhook (GitHub / GitLab / Bitbucket) - `'cli'`: an upload via the Vercel CLI - `'rest-api'`: a first-party REST API upload — a user or team token POSTing directly. Does NOT cover deploy-hook URLs or OAuth2 integration tokens; those are their own sources. - `'deploy-hook'`: a trigger via a project deploy-hook URL. The URL itself is the credential, so the request has no authenticated principal. - `'integration'`: an OAuth2 actor — a Marketplace integration token, a Vercel App token, or a user-delegated OAuth flow where an integration is acting on a user's behalf. Every deployment classifies to exactly one source; the values are mutually exclusive. See `classify-source` (in the policy package's consumers) for the canonical classification order. The split between `'rest-api'` and `'integration'` is intentional so a team can permit their own automation while blocking third-party integrators — or vice versa.
        /// </summary>
        Integration,
        /// <summary>
        /// a Git provider webhook (GitHub / GitLab / Bitbucket) - `'cli'`: an upload via the Vercel CLI - `'rest-api'`: a first-party REST API upload — a user or team token POSTing directly. Does NOT cover deploy-hook URLs or OAuth2 integration tokens; those are their own sources. - `'deploy-hook'`: a trigger via a project deploy-hook URL. The URL itself is the credential, so the request has no authenticated principal. - `'integration'`: an OAuth2 actor — a Marketplace integration token, a Vercel App token, or a user-delegated OAuth flow where an integration is acting on a user's behalf. Every deployment classifies to exactly one source; the values are mutually exclusive. See `classify-source` (in the policy package's consumers) for the canonical classification order. The split between `'rest-api'` and `'integration'` is intentional so a team can permit their own automation while blocking third-party integrators — or vice versa.
        /// </summary>
        RestApi,
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
                CreateProjectResponseDeploymentPolicyDeploymentSourcesSource.Cli => "cli",
                CreateProjectResponseDeploymentPolicyDeploymentSourcesSource.DeployHook => "deploy-hook",
                CreateProjectResponseDeploymentPolicyDeploymentSourcesSource.Git => "git",
                CreateProjectResponseDeploymentPolicyDeploymentSourcesSource.Integration => "integration",
                CreateProjectResponseDeploymentPolicyDeploymentSourcesSource.RestApi => "rest-api",
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
                "cli" => CreateProjectResponseDeploymentPolicyDeploymentSourcesSource.Cli,
                "deploy-hook" => CreateProjectResponseDeploymentPolicyDeploymentSourcesSource.DeployHook,
                "git" => CreateProjectResponseDeploymentPolicyDeploymentSourcesSource.Git,
                "integration" => CreateProjectResponseDeploymentPolicyDeploymentSourcesSource.Integration,
                "rest-api" => CreateProjectResponseDeploymentPolicyDeploymentSourcesSource.RestApi,
                _ => null,
            };
        }
    }
}