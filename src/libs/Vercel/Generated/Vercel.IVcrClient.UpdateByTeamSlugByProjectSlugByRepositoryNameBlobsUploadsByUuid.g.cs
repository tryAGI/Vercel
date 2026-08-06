#nullable enable

namespace Vercel
{
    public partial interface IVcrClient
    {
        /// <summary>
        /// Upload a blob chunk<br/>
        /// PATCH /v2/:teamSlug/:projectSlug/:repositoryName/blobs/uploads/:uuid Upload a chunk of blob data. The request body is streamed directly to S3 as a multipart upload part while hashing incrementally. The client may call this multiple times for chunked uploads.
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateByTeamSlugByProjectSlugByRepositoryNameBlobsUploadsByUuidAsync(
            string teamSlug,
            string projectSlug,
            string repositoryName,
            string uuid,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload a blob chunk<br/>
        /// PATCH /v2/:teamSlug/:projectSlug/:repositoryName/blobs/uploads/:uuid Upload a chunk of blob data. The request body is streamed directly to S3 as a multipart upload part while hashing incrementally. The client may call this multiple times for chunked uploads.
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<string>> UpdateByTeamSlugByProjectSlugByRepositoryNameBlobsUploadsByUuidAsResponseAsync(
            string teamSlug,
            string projectSlug,
            string repositoryName,
            string uuid,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}