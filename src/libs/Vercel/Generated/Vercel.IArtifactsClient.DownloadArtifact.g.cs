#nullable enable

namespace Vercel
{
    public partial interface IArtifactsClient
    {
        /// <summary>
        /// Download a cache artifact<br/>
        /// Downloads a cache artifact indentified by its `hash` specified on the request path. The artifact is downloaded as an octet-stream. The client should verify the content-length header and response body.
        /// </summary>
        /// <param name="xArtifactClientCi">
        /// The continuous integration or delivery environment where this artifact is downloaded.<br/>
        /// Example: VERCEL
        /// </param>
        /// <param name="xArtifactClientInteractive">
        /// 1 if the client is an interactive shell. Otherwise 0<br/>
        /// Example: 0
        /// </param>
        /// <param name="hash">
        /// The artifact hash<br/>
        /// Example: 12HKQaOmR5t5Uy6vdcQsNIiZgHGB
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> DownloadArtifactAsync(
            string hash,
            string? xArtifactClientCi = default,
            int? xArtifactClientInteractive = default,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}