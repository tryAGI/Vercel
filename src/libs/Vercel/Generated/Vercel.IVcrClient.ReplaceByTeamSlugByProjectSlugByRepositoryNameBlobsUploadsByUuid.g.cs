#nullable enable

namespace Vercel
{
    public partial interface IVcrClient
    {
        /// <summary>
        /// PUT /v2/:teamSlug/:projectSlug/:repositoryName/blobs/uploads/:uuid?digest=&lt;digest&gt; Complete the blob upload. This may include a final chunk of data in the request body (monolithic upload) or just finalize a previous chunked upload.
        /// </summary>
        /// <param name="teamSlug">
        /// Single Docker repository team slug component.<br/>
        /// Example: team-slug
        /// </param>
        /// <param name="projectSlug">
        /// Single Docker repository project slug component.<br/>
        /// Example: project-slug
        /// </param>
        /// <param name="repositoryName">
        /// Single Docker repository name component.<br/>
        /// Example: nginx
        /// </param>
        /// <param name="uuid">
        /// Blob upload session identifier.<br/>
        /// Example: 0123456789abcdef0123456789abcdef01234567
        /// </param>
        /// <param name="digest">
        /// Content-addressable digest (algorithm:hex).<br/>
        /// Example: sha256:e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ReplaceByTeamSlugByProjectSlugByRepositoryNameBlobsUploadsByUuidAsync(
            string teamSlug,
            string projectSlug,
            string repositoryName,
            string uuid,
            string digest,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// PUT /v2/:teamSlug/:projectSlug/:repositoryName/blobs/uploads/:uuid?digest=&lt;digest&gt; Complete the blob upload. This may include a final chunk of data in the request body (monolithic upload) or just finalize a previous chunked upload.
        /// </summary>
        /// <param name="teamSlug">
        /// Single Docker repository team slug component.<br/>
        /// Example: team-slug
        /// </param>
        /// <param name="projectSlug">
        /// Single Docker repository project slug component.<br/>
        /// Example: project-slug
        /// </param>
        /// <param name="repositoryName">
        /// Single Docker repository name component.<br/>
        /// Example: nginx
        /// </param>
        /// <param name="uuid">
        /// Blob upload session identifier.<br/>
        /// Example: 0123456789abcdef0123456789abcdef01234567
        /// </param>
        /// <param name="digest">
        /// Content-addressable digest (algorithm:hex).<br/>
        /// Example: sha256:e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<string>> ReplaceByTeamSlugByProjectSlugByRepositoryNameBlobsUploadsByUuidAsResponseAsync(
            string teamSlug,
            string projectSlug,
            string repositoryName,
            string uuid,
            string digest,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}