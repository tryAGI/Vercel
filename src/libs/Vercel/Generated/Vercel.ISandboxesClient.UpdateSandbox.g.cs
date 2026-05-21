#nullable enable

namespace Vercel
{
    public partial interface ISandboxesClient
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
        /// <param name="resume">
        /// Whether to automatically resume a stopped named sandbox by creating a new instance from its snapshot. Defaults to false.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.OneOf<global::Vercel.UpdateSandboxResponseVariant1, global::Vercel.UpdateSandboxResponseVariant2>> UpdateSandboxAsync(
            string name,

            global::Vercel.UpdateSandboxRequest request,
            string? projectId = default,
            bool? resume = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
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
        /// <param name="resume">
        /// Whether to automatically resume a stopped named sandbox by creating a new instance from its snapshot. Defaults to false.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.OneOf<global::Vercel.UpdateSandboxResponseVariant1, global::Vercel.UpdateSandboxResponseVariant2>>> UpdateSandboxAsResponseAsync(
            string name,

            global::Vercel.UpdateSandboxRequest request,
            string? projectId = default,
            bool? resume = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
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
        /// <param name="resume">
        /// Whether to automatically resume a stopped named sandbox by creating a new instance from its snapshot. Defaults to false.<br/>
        /// Default Value: false
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
        /// <param name="keepLastSnapshots">
        /// Protect the N most recent snapshots with different expiration/deletion behavior. Set to null to clear.
        /// </param>
        /// <param name="networkPolicy"></param>
        /// <param name="env">
        /// Default environment variables for the sandbox. Set to empty object to clear.<br/>
        /// Example: {"NODE_ENV":"production","HELLO":"world"}
        /// </param>
        /// <param name="ports">
        /// List of ports to expose from the sandbox. Each port will be accessible via a unique URL. Maximum of 15 ports can be exposed.<br/>
        /// Example: [3000, 4000]
        /// </param>
        /// <param name="currentSnapshotId">
        /// The snapshot ID to set as the current snapshot. Must be active and belong to the same project.
        /// </param>
        /// <param name="tags">
        /// Key-value tags to associate with the sandbox. Replaces existing tags. Set to empty object to clear. Maximum 5 tags.<br/>
        /// Example: {"env":"staging","team":"platform"}
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.OneOf<global::Vercel.UpdateSandboxResponseVariant1, global::Vercel.UpdateSandboxResponseVariant2>> UpdateSandboxAsync(
            string name,
            string? projectId = default,
            bool? resume = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.UpdateSandboxRequestResources? resources = default,
            global::Vercel.UpdateSandboxRequestRuntime? runtime = default,
            int? timeout = default,
            bool? persistent = default,
            global::Vercel.OneOf<object, int?>? snapshotExpiration = default,
            global::Vercel.OneOf<string, global::Vercel.UpdateSandboxRequestKeepLastSnapshots>? keepLastSnapshots = default,
            global::Vercel.OneOf<global::Vercel.UpdateSandboxRequestNetworkPolicyVariant1, global::Vercel.UpdateSandboxRequestNetworkPolicyVariant2>? networkPolicy = default,
            global::System.Collections.Generic.Dictionary<string, string>? env = default,
            global::System.Collections.Generic.IList<int>? ports = default,
            string? currentSnapshotId = default,
            global::System.Collections.Generic.Dictionary<string, string>? tags = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}