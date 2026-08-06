#nullable enable

namespace Vercel
{
    public partial interface IVcrClient
    {
        /// <summary>
        /// Start a blob upload<br/>
        /// POST /v2/:teamSlug/:projectSlug/:repositoryName/blobs/uploads/[?mount=&lt;digest&gt;&amp;from=&lt;repo&gt;] Initiate a blob upload. Returns a UUID in the Location header that the client uses for subsequent PATCH (chunk) and PUT (complete) requests.
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
        /// <param name="mount">
        /// Digest of the blob to mount from another repository.
        /// </param>
        /// <param name="from">
        /// Source repository to mount the blob from.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CreateByTeamSlugByProjectSlugByRepositoryNameBlobsUploadsAsync(
            string teamSlug,
            string projectSlug,
            string repositoryName,
            string? mount = default,
            string? from = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Start a blob upload<br/>
        /// POST /v2/:teamSlug/:projectSlug/:repositoryName/blobs/uploads/[?mount=&lt;digest&gt;&amp;from=&lt;repo&gt;] Initiate a blob upload. Returns a UUID in the Location header that the client uses for subsequent PATCH (chunk) and PUT (complete) requests.
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
        /// <param name="mount">
        /// Digest of the blob to mount from another repository.
        /// </param>
        /// <param name="from">
        /// Source repository to mount the blob from.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<string>> CreateByTeamSlugByProjectSlugByRepositoryNameBlobsUploadsAsResponseAsync(
            string teamSlug,
            string projectSlug,
            string repositoryName,
            string? mount = default,
            string? from = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}