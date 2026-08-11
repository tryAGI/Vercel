#nullable enable

namespace Vercel
{
    public partial interface IVcrClient
    {
        /// <summary>
        /// Delete a blob<br/>
        /// DELETE /v2/:teamSlug/:projectSlug/:repositoryName/blobs/:digest Blob deletion is intentionally not supported. Matches the behaviour of most public registries.
        /// </summary>
        /// <param name="teamSlug">
        /// Single Docker repository team slug or team ID component.<br/>
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
        /// <param name="digest">
        /// Content-addressable digest (algorithm:hex).<br/>
        /// Example: sha256:e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteByTeamSlugByProjectSlugByRepositoryNameBlobsByDigestAsync(
            string teamSlug,
            string projectSlug,
            string repositoryName,
            string digest,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a blob<br/>
        /// DELETE /v2/:teamSlug/:projectSlug/:repositoryName/blobs/:digest Blob deletion is intentionally not supported. Matches the behaviour of most public registries.
        /// </summary>
        /// <param name="teamSlug">
        /// Single Docker repository team slug or team ID component.<br/>
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
        /// <param name="digest">
        /// Content-addressable digest (algorithm:hex).<br/>
        /// Example: sha256:e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse> DeleteByTeamSlugByProjectSlugByRepositoryNameBlobsByDigestAsResponseAsync(
            string teamSlug,
            string projectSlug,
            string repositoryName,
            string digest,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}