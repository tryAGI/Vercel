
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The mechanism that produced a deployment, expressed as values a customer can write in a {@link DeploymentSourcesRule} allowlist. The JSON schema at `packages/deployment-policy/schemas/body.ts` enumerates exactly these values. - `'git'`: a Git provider webhook (GitHub / GitLab / Bitbucket). - `'cli'`: an upload via the Vercel CLI. Covers both the legacy CLI (classic user token, identified by `vercel`/`now` user-agent) and the Sign-In-With-Vercel CLI (a first-party Vercel App token whose `clientId` is the CLI's). The canonical CLI client IDs are tracked in `packages/acl/app-has-all-permissions.ts` (`isVercelCliApp`). - `'rest-api'`: a direct REST API upload — a user or team token POSTing directly. Does NOT cover deploy-hook URLs, Marketplace integration tokens, or first-party Vercel App tokens; those are their own sources. - `'deploy-hook'`: a trigger via a project deploy-hook URL. The URL itself is the credential, so the request has no authenticated principal. - `'integration'`: a **third-party Marketplace** OAuth2 actor — a Marketplace integration token, a user-delegated OAuth flow where a Marketplace integration is acting on a user's behalf, or an unrecognized third-party Vercel App token. First-party Vercel Apps are NEVER `'integration'`. Vercel-owned first-party apps other than the CLI (e.g. v0, Toolbar, Omni Agent) are *not* in this type — they aren't customer-configurable. They classify as `'first-party'` (see `ClassifiedSource` in `@api/deployment-policy/checks`) and are auto-allowed by `checkDeploymentSources`. The split is intentional: a team can permit their own automation and CLI usage while blocking third-party Marketplace integrators — and Vercel's own first-party tooling always works.
    /// </summary>
    public enum UpdateProjectResponseDeploymentPolicyDeploymentSourcesSource
    {
        /// <summary>
        /// a Git provider webhook (GitHub / GitLab / Bitbucket). - `'cli'`: an upload via the Vercel CLI. Covers both the legacy CLI (classic user token, identified by `vercel`/`now` user-agent) and the Sign-In-With-Vercel CLI (a first-party Vercel App token whose `clientId` is the CLI's). The canonical CLI client IDs are tracked in `packages/acl/app-has-all-permissions.ts` (`isVercelCliApp`). - `'rest-api'`: a direct REST API upload — a user or team token POSTing directly. Does NOT cover deploy-hook URLs, Marketplace integration tokens, or first-party Vercel App tokens; those are their own sources. - `'deploy-hook'`: a trigger via a project deploy-hook URL. The URL itself is the credential, so the request has no authenticated principal. - `'integration'`: a **third-party Marketplace** OAuth2 actor — a Marketplace integration token, a user-delegated OAuth flow where a Marketplace integration is acting on a user's behalf, or an unrecognized third-party Vercel App token. First-party Vercel Apps are NEVER `'integration'`. Vercel-owned first-party apps other than the CLI (e.g. v0, Toolbar, Omni Agent) are *not* in this type — they aren't customer-configurable. They classify as `'first-party'` (see `ClassifiedSource` in `@api/deployment-policy/checks`) and are auto-allowed by `checkDeploymentSources`. The split is intentional: a team can permit their own automation and CLI usage while blocking third-party Marketplace integrators — and Vercel's own first-party tooling always works.
        /// </summary>
        Cli,
        /// <summary>
        /// a Git provider webhook (GitHub / GitLab / Bitbucket). - `'cli'`: an upload via the Vercel CLI. Covers both the legacy CLI (classic user token, identified by `vercel`/`now` user-agent) and the Sign-In-With-Vercel CLI (a first-party Vercel App token whose `clientId` is the CLI's). The canonical CLI client IDs are tracked in `packages/acl/app-has-all-permissions.ts` (`isVercelCliApp`). - `'rest-api'`: a direct REST API upload — a user or team token POSTing directly. Does NOT cover deploy-hook URLs, Marketplace integration tokens, or first-party Vercel App tokens; those are their own sources. - `'deploy-hook'`: a trigger via a project deploy-hook URL. The URL itself is the credential, so the request has no authenticated principal. - `'integration'`: a **third-party Marketplace** OAuth2 actor — a Marketplace integration token, a user-delegated OAuth flow where a Marketplace integration is acting on a user's behalf, or an unrecognized third-party Vercel App token. First-party Vercel Apps are NEVER `'integration'`. Vercel-owned first-party apps other than the CLI (e.g. v0, Toolbar, Omni Agent) are *not* in this type — they aren't customer-configurable. They classify as `'first-party'` (see `ClassifiedSource` in `@api/deployment-policy/checks`) and are auto-allowed by `checkDeploymentSources`. The split is intentional: a team can permit their own automation and CLI usage while blocking third-party Marketplace integrators — and Vercel's own first-party tooling always works.
        /// </summary>
        DeployHook,
        /// <summary>
        /// a Git provider webhook (GitHub / GitLab / Bitbucket). - `'cli'`: an upload via the Vercel CLI. Covers both the legacy CLI (classic user token, identified by `vercel`/`now` user-agent) and the Sign-In-With-Vercel CLI (a first-party Vercel App token whose `clientId` is the CLI's). The canonical CLI client IDs are tracked in `packages/acl/app-has-all-permissions.ts` (`isVercelCliApp`). - `'rest-api'`: a direct REST API upload — a user or team token POSTing directly. Does NOT cover deploy-hook URLs, Marketplace integration tokens, or first-party Vercel App tokens; those are their own sources. - `'deploy-hook'`: a trigger via a project deploy-hook URL. The URL itself is the credential, so the request has no authenticated principal. - `'integration'`: a **third-party Marketplace** OAuth2 actor — a Marketplace integration token, a user-delegated OAuth flow where a Marketplace integration is acting on a user's behalf, or an unrecognized third-party Vercel App token. First-party Vercel Apps are NEVER `'integration'`. Vercel-owned first-party apps other than the CLI (e.g. v0, Toolbar, Omni Agent) are *not* in this type — they aren't customer-configurable. They classify as `'first-party'` (see `ClassifiedSource` in `@api/deployment-policy/checks`) and are auto-allowed by `checkDeploymentSources`. The split is intentional: a team can permit their own automation and CLI usage while blocking third-party Marketplace integrators — and Vercel's own first-party tooling always works.
        /// </summary>
        Git,
        /// <summary>
        /// a Git provider webhook (GitHub / GitLab / Bitbucket). - `'cli'`: an upload via the Vercel CLI. Covers both the legacy CLI (classic user token, identified by `vercel`/`now` user-agent) and the Sign-In-With-Vercel CLI (a first-party Vercel App token whose `clientId` is the CLI's). The canonical CLI client IDs are tracked in `packages/acl/app-has-all-permissions.ts` (`isVercelCliApp`). - `'rest-api'`: a direct REST API upload — a user or team token POSTing directly. Does NOT cover deploy-hook URLs, Marketplace integration tokens, or first-party Vercel App tokens; those are their own sources. - `'deploy-hook'`: a trigger via a project deploy-hook URL. The URL itself is the credential, so the request has no authenticated principal. - `'integration'`: a **third-party Marketplace** OAuth2 actor — a Marketplace integration token, a user-delegated OAuth flow where a Marketplace integration is acting on a user's behalf, or an unrecognized third-party Vercel App token. First-party Vercel Apps are NEVER `'integration'`. Vercel-owned first-party apps other than the CLI (e.g. v0, Toolbar, Omni Agent) are *not* in this type — they aren't customer-configurable. They classify as `'first-party'` (see `ClassifiedSource` in `@api/deployment-policy/checks`) and are auto-allowed by `checkDeploymentSources`. The split is intentional: a team can permit their own automation and CLI usage while blocking third-party Marketplace integrators — and Vercel's own first-party tooling always works.
        /// </summary>
        Integration,
        /// <summary>
        /// a Git provider webhook (GitHub / GitLab / Bitbucket). - `'cli'`: an upload via the Vercel CLI. Covers both the legacy CLI (classic user token, identified by `vercel`/`now` user-agent) and the Sign-In-With-Vercel CLI (a first-party Vercel App token whose `clientId` is the CLI's). The canonical CLI client IDs are tracked in `packages/acl/app-has-all-permissions.ts` (`isVercelCliApp`). - `'rest-api'`: a direct REST API upload — a user or team token POSTing directly. Does NOT cover deploy-hook URLs, Marketplace integration tokens, or first-party Vercel App tokens; those are their own sources. - `'deploy-hook'`: a trigger via a project deploy-hook URL. The URL itself is the credential, so the request has no authenticated principal. - `'integration'`: a **third-party Marketplace** OAuth2 actor — a Marketplace integration token, a user-delegated OAuth flow where a Marketplace integration is acting on a user's behalf, or an unrecognized third-party Vercel App token. First-party Vercel Apps are NEVER `'integration'`. Vercel-owned first-party apps other than the CLI (e.g. v0, Toolbar, Omni Agent) are *not* in this type — they aren't customer-configurable. They classify as `'first-party'` (see `ClassifiedSource` in `@api/deployment-policy/checks`) and are auto-allowed by `checkDeploymentSources`. The split is intentional: a team can permit their own automation and CLI usage while blocking third-party Marketplace integrators — and Vercel's own first-party tooling always works.
        /// </summary>
        RestApi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateProjectResponseDeploymentPolicyDeploymentSourcesSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseDeploymentPolicyDeploymentSourcesSource value)
        {
            return value switch
            {
                UpdateProjectResponseDeploymentPolicyDeploymentSourcesSource.Cli => "cli",
                UpdateProjectResponseDeploymentPolicyDeploymentSourcesSource.DeployHook => "deploy-hook",
                UpdateProjectResponseDeploymentPolicyDeploymentSourcesSource.Git => "git",
                UpdateProjectResponseDeploymentPolicyDeploymentSourcesSource.Integration => "integration",
                UpdateProjectResponseDeploymentPolicyDeploymentSourcesSource.RestApi => "rest-api",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseDeploymentPolicyDeploymentSourcesSource? ToEnum(string value)
        {
            return value switch
            {
                "cli" => UpdateProjectResponseDeploymentPolicyDeploymentSourcesSource.Cli,
                "deploy-hook" => UpdateProjectResponseDeploymentPolicyDeploymentSourcesSource.DeployHook,
                "git" => UpdateProjectResponseDeploymentPolicyDeploymentSourcesSource.Git,
                "integration" => UpdateProjectResponseDeploymentPolicyDeploymentSourcesSource.Integration,
                "rest-api" => UpdateProjectResponseDeploymentPolicyDeploymentSourcesSource.RestApi,
                _ => null,
            };
        }
    }
}