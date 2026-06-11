
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Customer-configurable deployment sources. Every deploy classifies to exactly one. JSON schema in `packages/deployment-policy/schemas/body.ts` enumerates exactly these values. - `'git'` — git provider webhook. - `'cli'` — Vercel CLI (legacy classic-token CLI and SIWV CLI both). - `'rest-api'` — direct user/team-token REST upload. Does NOT cover deploy hooks, Marketplace integrations, or first-party app tokens. - `'deploy-hook'` — project deploy-hook URL. The URL is the credential. - `'integration'` — third-party Marketplace actor: Marketplace integration token, user-delegated OAuth from a Marketplace app, or an unrecognized third-party Vercel App. First-party Vercel Apps are never `'integration'`. - `'v0'` — the v0 product surface (entitlement-gated). v0 deploys through the CLI under the hood, but classifies as its own source so a team can allow or deny v0 independently of `'cli'`. First-party Vercel apps (Toolbar, etc.) classify as `'first-party'` — see `ClassifiedSource` in `./checks`. They're not in this union because they aren't customer-configurable; they bypass `checkDeploymentSources` entirely. v0 is intentionally NOT among them: like the CLI, it's a real product surface and is policy-controllable.
    /// </summary>
    public enum UploadProjectAvatarResponseDeploymentPolicyDeploymentSourceSource
    {
        /// <summary>
        /// Marketplace integration token, user-delegated OAuth from a Marketplace app, or an unrecognized third-party Vercel App. First-party Vercel Apps are never `'integration'`. - `'v0'` — the v0 product surface (entitlement-gated). v0 deploys through the CLI under the hood, but classifies as its own source so a team can allow or deny v0 independently of `'cli'`. First-party Vercel apps (Toolbar, etc.) classify as `'first-party'` — see `ClassifiedSource` in `./checks`. They're not in this union because they aren't customer-configurable; they bypass `checkDeploymentSources` entirely. v0 is intentionally NOT among them: like the CLI, it's a real product surface and is policy-controllable.
        /// </summary>
        Cli,
        /// <summary>
        /// Marketplace integration token, user-delegated OAuth from a Marketplace app, or an unrecognized third-party Vercel App. First-party Vercel Apps are never `'integration'`. - `'v0'` — the v0 product surface (entitlement-gated). v0 deploys through the CLI under the hood, but classifies as its own source so a team can allow or deny v0 independently of `'cli'`. First-party Vercel apps (Toolbar, etc.) classify as `'first-party'` — see `ClassifiedSource` in `./checks`. They're not in this union because they aren't customer-configurable; they bypass `checkDeploymentSources` entirely. v0 is intentionally NOT among them: like the CLI, it's a real product surface and is policy-controllable.
        /// </summary>
        DeployHook,
        /// <summary>
        /// Marketplace integration token, user-delegated OAuth from a Marketplace app, or an unrecognized third-party Vercel App. First-party Vercel Apps are never `'integration'`. - `'v0'` — the v0 product surface (entitlement-gated). v0 deploys through the CLI under the hood, but classifies as its own source so a team can allow or deny v0 independently of `'cli'`. First-party Vercel apps (Toolbar, etc.) classify as `'first-party'` — see `ClassifiedSource` in `./checks`. They're not in this union because they aren't customer-configurable; they bypass `checkDeploymentSources` entirely. v0 is intentionally NOT among them: like the CLI, it's a real product surface and is policy-controllable.
        /// </summary>
        Git,
        /// <summary>
        /// Marketplace integration token, user-delegated OAuth from a Marketplace app, or an unrecognized third-party Vercel App. First-party Vercel Apps are never `'integration'`. - `'v0'` — the v0 product surface (entitlement-gated). v0 deploys through the CLI under the hood, but classifies as its own source so a team can allow or deny v0 independently of `'cli'`. First-party Vercel apps (Toolbar, etc.) classify as `'first-party'` — see `ClassifiedSource` in `./checks`. They're not in this union because they aren't customer-configurable; they bypass `checkDeploymentSources` entirely. v0 is intentionally NOT among them: like the CLI, it's a real product surface and is policy-controllable.
        /// </summary>
        Integration,
        /// <summary>
        /// Marketplace integration token, user-delegated OAuth from a Marketplace app, or an unrecognized third-party Vercel App. First-party Vercel Apps are never `'integration'`. - `'v0'` — the v0 product surface (entitlement-gated). v0 deploys through the CLI under the hood, but classifies as its own source so a team can allow or deny v0 independently of `'cli'`. First-party Vercel apps (Toolbar, etc.) classify as `'first-party'` — see `ClassifiedSource` in `./checks`. They're not in this union because they aren't customer-configurable; they bypass `checkDeploymentSources` entirely. v0 is intentionally NOT among them: like the CLI, it's a real product surface and is policy-controllable.
        /// </summary>
        RestApi,
        /// <summary>
        /// Marketplace integration token, user-delegated OAuth from a Marketplace app, or an unrecognized third-party Vercel App. First-party Vercel Apps are never `'integration'`. - `'v0'` — the v0 product surface (entitlement-gated). v0 deploys through the CLI under the hood, but classifies as its own source so a team can allow or deny v0 independently of `'cli'`. First-party Vercel apps (Toolbar, etc.) classify as `'first-party'` — see `ClassifiedSource` in `./checks`. They're not in this union because they aren't customer-configurable; they bypass `checkDeploymentSources` entirely. v0 is intentionally NOT among them: like the CLI, it's a real product surface and is policy-controllable.
        /// </summary>
        V0,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UploadProjectAvatarResponseDeploymentPolicyDeploymentSourceSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseDeploymentPolicyDeploymentSourceSource value)
        {
            return value switch
            {
                UploadProjectAvatarResponseDeploymentPolicyDeploymentSourceSource.Cli => "cli",
                UploadProjectAvatarResponseDeploymentPolicyDeploymentSourceSource.DeployHook => "deploy-hook",
                UploadProjectAvatarResponseDeploymentPolicyDeploymentSourceSource.Git => "git",
                UploadProjectAvatarResponseDeploymentPolicyDeploymentSourceSource.Integration => "integration",
                UploadProjectAvatarResponseDeploymentPolicyDeploymentSourceSource.RestApi => "rest-api",
                UploadProjectAvatarResponseDeploymentPolicyDeploymentSourceSource.V0 => "v0",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseDeploymentPolicyDeploymentSourceSource? ToEnum(string value)
        {
            return value switch
            {
                "cli" => UploadProjectAvatarResponseDeploymentPolicyDeploymentSourceSource.Cli,
                "deploy-hook" => UploadProjectAvatarResponseDeploymentPolicyDeploymentSourceSource.DeployHook,
                "git" => UploadProjectAvatarResponseDeploymentPolicyDeploymentSourceSource.Git,
                "integration" => UploadProjectAvatarResponseDeploymentPolicyDeploymentSourceSource.Integration,
                "rest-api" => UploadProjectAvatarResponseDeploymentPolicyDeploymentSourceSource.RestApi,
                "v0" => UploadProjectAvatarResponseDeploymentPolicyDeploymentSourceSource.V0,
                _ => null,
            };
        }
    }
}