#nullable enable

namespace Vercel
{
    public partial interface ISandboxesV2BetaClient
    {
        /// <summary>
        /// Create a named sandbox<br/>
        /// Creates a named sandbox environment. Named sandboxes have a unique name within a project and support automatic snapshotting on shutdown.
        /// </summary>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.CreateSandboxesResponse> CreateSandboxesAsync(

            global::Vercel.CreateSandboxesRequest request,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a named sandbox<br/>
        /// Creates a named sandbox environment. Named sandboxes have a unique name within a project and support automatic snapshotting on shutdown.
        /// </summary>
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
        /// Default Value: node24<br/>
        /// Example: node24
        /// </param>
        /// <param name="source">
        /// The source from which to initialize the sandbox filesystem. Can be a Git repository, a tarball URL, or an existing snapshot.
        /// </param>
        /// <param name="projectId">
        /// The target project slug or ID in which the sandbox will be assigned to.<br/>
        /// Example: prj_abc123
        /// </param>
        /// <param name="ports">
        /// List of ports to expose from the sandbox. Each port will be accessible via a unique URL. Maximum of 15 ports can be exposed.<br/>
        /// Example: [3000, 4000]
        /// </param>
        /// <param name="timeout">
        /// Maximum duration in milliseconds that the sandbox can run before being automatically stopped.<br/>
        /// Example: 300000
        /// </param>
        /// <param name="networkPolicy">
        /// Network access policy for the sandbox.\n    Controls which external hosts the sandbox can communicate with.\n    Use \"allow-all\" mode to allow all traffic, \"deny-all\" to block all traffic or \"custom\" to provide specific rules.
        /// </param>
        /// <param name="env">
        /// Default environment variables for the sandbox. These are inherited by all commands unless overridden.<br/>
        /// Default Value: {}<br/>
        /// Example: {"NODE_ENV":"production","HELLO":"world"}
        /// </param>
        /// <param name="name">
        /// Name for the sandbox. Must be unique per project and URL-safe (alphanumeric, hyphens, underscores).<br/>
        /// Example: my-sandbox
        /// </param>
        /// <param name="persistent">
        /// Whether the sandbox persists its state across restarts via automatic snapshots. Defaults to true.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="snapshotExpiration">
        /// Default snapshot expiration time in milliseconds. Set to 0 to disable expiration. When set, this value is used as the default expiration for all snapshots created for this sandbox.<br/>
        /// Example: 604800000
        /// </param>
        /// <param name="tags">
        /// Key-value tags to associate with the sandbox. Maximum 5 tags.<br/>
        /// Example: {"env":"staging","team":"platform"}
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.CreateSandboxesResponse> CreateSandboxesAsync(
            string? teamId = default,
            string? slug = default,
            global::Vercel.CreateSandboxesRequestResources? resources = default,
            global::Vercel.CreateSandboxesRequestRuntime? runtime = default,
            global::Vercel.OneOf<global::Vercel.CreateSandboxesRequestSourceVariant1, global::Vercel.CreateSandboxesRequestSourceVariant2, global::Vercel.CreateSandboxesRequestSourceVariant3>? source = default,
            string? projectId = default,
            global::System.Collections.Generic.IList<int>? ports = default,
            int? timeout = default,
            global::Vercel.CreateSandboxesRequestNetworkPolicy? networkPolicy = default,
            global::System.Collections.Generic.Dictionary<string, string>? env = default,
            string? name = default,
            bool? persistent = default,
            global::Vercel.OneOf<object, int?>? snapshotExpiration = default,
            global::System.Collections.Generic.Dictionary<string, string>? tags = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}