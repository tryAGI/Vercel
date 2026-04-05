#nullable enable

namespace Vercel
{
    public partial interface ISandboxesV2BetaClient
    {
        /// <summary>
        /// Update a sandbox<br/>
        /// Updates the configuration of a sandbox. Only the provided fields will be modified; omitted fields remain unchanged.
        /// </summary>
        /// <param name="name">
        /// The sandbox to update.<br/>
        /// Example: my-sandbox
        /// </param>
        /// <param name="projectId">
        /// The project ID that owns the named sandbox. When provided, takes precedence over OIDC project context.
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.UpdateSandboxResponse> UpdateSandboxAsync(
            string name,

            global::Vercel.UpdateSandboxRequest request,
            string? projectId = default,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a sandbox<br/>
        /// Updates the configuration of a sandbox. Only the provided fields will be modified; omitted fields remain unchanged.
        /// </summary>
        /// <param name="name">
        /// The sandbox to update.<br/>
        /// Example: my-sandbox
        /// </param>
        /// <param name="projectId">
        /// The project ID that owns the named sandbox. When provided, takes precedence over OIDC project context.
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="resources">
        /// Resources to define the VM
        /// </param>
        /// <param name="runtime">
        /// The runtime environment for the sandbox. Determines the pre-installed language runtimes and tools available.<br/>
        /// Example: node24
        /// </param>
        /// <param name="timeout">
        /// Maximum duration in milliseconds that the sandbox can run before being automatically stopped.<br/>
        /// Example: 300000
        /// </param>
        /// <param name="persistent">
        /// Whether the sandbox persists its state across restarts via automatic snapshots.
        /// </param>
        /// <param name="snapshotExpiration">
        /// Default snapshot expiration time in milliseconds. Set to 0 to disable expiration. When set, this value is used as the default expiration for all snapshots created for this sandbox.<br/>
        /// Example: 604800000
        /// </param>
        /// <param name="networkPolicy">
        /// Network access policy for the sandbox.\n    Controls which external hosts the sandbox can communicate with.\n    Use \"allow-all\" mode to allow all traffic, \"deny-all\" to block all traffic or \"custom\" to provide specific rules.
        /// </param>
        /// <param name="env">
        /// Default environment variables for the sandbox. Set to empty object to clear.<br/>
        /// Example: {"NODE_ENV":"production","HELLO":"world"}
        /// </param>
        /// <param name="tags">
        /// Key-value tags to associate with the sandbox. Replaces existing tags. Set to empty object to clear. Maximum 5 tags.<br/>
        /// Example: {"env":"staging","team":"platform"}
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.UpdateSandboxResponse> UpdateSandboxAsync(
            string name,
            string? projectId = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.UpdateSandboxRequestResources? resources = default,
            global::Vercel.UpdateSandboxRequestRuntime? runtime = default,
            int? timeout = default,
            bool? persistent = default,
            global::Vercel.OneOf<object, int?>? snapshotExpiration = default,
            global::Vercel.UpdateSandboxRequestNetworkPolicy? networkPolicy = default,
            global::System.Collections.Generic.Dictionary<string, string>? env = default,
            global::System.Collections.Generic.Dictionary<string, string>? tags = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}