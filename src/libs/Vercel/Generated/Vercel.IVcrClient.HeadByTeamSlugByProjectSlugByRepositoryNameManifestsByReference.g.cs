#nullable enable

namespace Vercel
{
    public partial interface IVcrClient
    {
        /// <summary>
        /// HEAD /v2/:teamSlug/:projectSlug/:repositoryName/manifests/:reference Check whether a manifest exists. Used by Docker client during push to determine if a manifest (or config blob referenced by digest) is already present.
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
        /// <param name="reference">
        /// Manifest reference: a tag or digest.<br/>
        /// Example: latest
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> HeadByTeamSlugByProjectSlugByRepositoryNameManifestsByReferenceAsync(
            string teamSlug,
            string projectSlug,
            string repositoryName,
            string reference,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// HEAD /v2/:teamSlug/:projectSlug/:repositoryName/manifests/:reference Check whether a manifest exists. Used by Docker client during push to determine if a manifest (or config blob referenced by digest) is already present.
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
        /// <param name="reference">
        /// Manifest reference: a tag or digest.<br/>
        /// Example: latest
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<string>> HeadByTeamSlugByProjectSlugByRepositoryNameManifestsByReferenceAsResponseAsync(
            string teamSlug,
            string projectSlug,
            string repositoryName,
            string reference,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}