#nullable enable

namespace Vercel
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Create a sandbox<br/>
        /// Creates a new sandbox environment for executing code in an isolated virtual machine. A sandbox can be initialized from various sources including Git repositories, tarballs, or existing snapshots. Once created, you can execute commands, read/write files, and manage the sandbox lifecycle.
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
        global::System.Threading.Tasks.Task<global::Vercel.CreateSandboxResponse> CreateSandboxAsync(

            global::Vercel.CreateSandboxRequest request,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a sandbox<br/>
        /// Creates a new sandbox environment for executing code in an isolated virtual machine. A sandbox can be initialized from various sources including Git repositories, tarballs, or existing snapshots. Once created, you can execute commands, read/write files, and manage the sandbox lifecycle.
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.CreateSandboxResponse> CreateSandboxAsync(
            string? teamId = default,
            string? slug = default,
            global::Vercel.CreateSandboxRequestResources? resources = default,
            global::Vercel.CreateSandboxRequestRuntime? runtime = default,
            global::Vercel.OneOf<global::Vercel.CreateSandboxRequestSourceVariant1, global::Vercel.CreateSandboxRequestSourceVariant2, global::Vercel.CreateSandboxRequestSourceVariant3>? source = default,
            string? projectId = default,
            global::System.Collections.Generic.IList<int>? ports = default,
            int? timeout = default,
            global::Vercel.CreateSandboxRequestNetworkPolicy? networkPolicy = default,
            global::System.Collections.Generic.Dictionary<string, string>? env = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}