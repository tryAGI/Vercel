#nullable enable

namespace Vercel
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Create a directory<br/>
        /// Creates a new directory in a sandbox's filesystem. By default, parent directories are created recursively if they don't exist (similar to `mkdir -p`).
        /// </summary>
        /// <param name="sandboxId">
        /// The unique identifier of the sandbox to create the directory in.<br/>
        /// Example: sbx_abc123
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
        global::System.Threading.Tasks.Task<string> CreateDirectoryAsync(
            string sandboxId,

            global::Vercel.CreateDirectoryRequest request,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a directory<br/>
        /// Creates a new directory in a sandbox's filesystem. By default, parent directories are created recursively if they don't exist (similar to `mkdir -p`).
        /// </summary>
        /// <param name="sandboxId">
        /// The unique identifier of the sandbox to create the directory in.<br/>
        /// Example: sbx_abc123
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="cwd">
        /// The base directory for resolving relative paths. If not specified, paths are resolved from the sandbox home directory.<br/>
        /// Example: /home/vercel-sandbox
        /// </param>
        /// <param name="path">
        /// The path of the directory to create. Can be absolute or relative to the working directory.<br/>
        /// Example: src/components
        /// </param>
        /// <param name="recursive">
        /// If true, creates parent directories as needed (like `mkdir -p`). If false, fails if parent directories do not exist.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> CreateDirectoryAsync(
            string sandboxId,
            string path,
            string? teamId = default,
            string? slug = default,
            string? cwd = default,
            bool? recursive = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}