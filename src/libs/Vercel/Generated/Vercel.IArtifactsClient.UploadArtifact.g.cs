#nullable enable

namespace Vercel
{
    public partial interface IArtifactsClient
    {
        /// <summary>
        /// Upload a cache artifact<br/>
        /// Uploads a cache artifact identified by the `hash` specified on the path. The cache artifact can then be downloaded with the provided `hash`.
        /// </summary>
        /// <param name="contentLength">
        /// The artifact size in bytes
        /// </param>
        /// <param name="xArtifactDuration">
        /// The time taken to generate the uploaded artifact in milliseconds.<br/>
        /// Example: 400
        /// </param>
        /// <param name="xArtifactClientCi">
        /// The continuous integration or delivery environment where this artifact was generated.<br/>
        /// Example: VERCEL
        /// </param>
        /// <param name="xArtifactClientInteractive">
        /// 1 if the client is an interactive shell. Otherwise 0<br/>
        /// Example: 0
        /// </param>
        /// <param name="xArtifactTag">
        /// The base64 encoded tag for this artifact. The value is sent back to clients when the artifact is downloaded as the header `x-artifact-tag`<br/>
        /// Example: Tc0BmHvJYMIYJ62/zx87YqO0Flxk+5Ovip25NY825CQ=
        /// </param>
        /// <param name="xArtifactSha">
        /// The SHA of the source control revision that generated this artifact.
        /// </param>
        /// <param name="xArtifactDirtyHash">
        /// A hash representing uncommitted changes in the working directory when this artifact was generated.
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
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.UploadArtifactResponse> UploadArtifactAsync(
            double contentLength,
            string hash,

            byte[] request,
            double? xArtifactDuration = default,
            string? xArtifactClientCi = default,
            int? xArtifactClientInteractive = default,
            string? xArtifactTag = default,
            string? xArtifactSha = default,
            string? xArtifactDirtyHash = default,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}