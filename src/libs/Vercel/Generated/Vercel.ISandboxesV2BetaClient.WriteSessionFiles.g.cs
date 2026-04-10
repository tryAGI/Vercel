#nullable enable

namespace Vercel
{
    public partial interface ISandboxesV2BetaClient
    {
        /// <summary>
        /// Write files<br/>
        /// Uploads and extracts files to a session's filesystem. Files must be uploaded as a gzipped tarball (`.tar.gz`) with the `Content-Type` header set to `application/gzip`. The tarball contents are extracted to the session's working directory, or to a custom directory specified via the `x-cwd` header.
        /// </summary>
        /// <param name="xCwd">
        /// The target directory where the tarball contents will be extracted. If not specified, files are extracted to the sandbox home directory.<br/>
        /// Example: /home/vercel-sandbox
        /// </param>
        /// <param name="sessionId">
        /// The unique identifier of the session to write files to.<br/>
        /// Example: sbx_abc123
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> WriteSessionFilesAsync(
            string sessionId,
            string? xCwd = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}