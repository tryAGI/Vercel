#nullable enable

namespace Vercel
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Read a file<br/>
        /// Downloads the contents of a file from a sandbox's filesystem. The file content is returned as a binary stream with appropriate Content-Disposition headers for file download.
        /// </summary>
        /// <param name="sandboxId">
        /// The unique identifier of the sandbox to read the file from.<br/>
        /// Example: sbx_abc123
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
        global::System.Threading.Tasks.Task<byte[]> ReadFileAsync(
            string sandboxId,

            global::Vercel.ReadFileRequest request,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Read a file<br/>
        /// Downloads the contents of a file from a sandbox's filesystem. The file content is returned as a binary stream with appropriate Content-Disposition headers for file download.
        /// </summary>
        /// <param name="sandboxId">
        /// The unique identifier of the sandbox to read the file from.<br/>
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
        /// The path of the file to read. Can be absolute or relative to the working directory.<br/>
        /// Example: dist/agent-output.md
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<byte[]> ReadFileAsync(
            string sandboxId,
            string path,
            string? teamId = default,
            string? slug = default,
            string? cwd = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}