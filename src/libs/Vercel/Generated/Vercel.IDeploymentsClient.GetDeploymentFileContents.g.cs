#nullable enable

namespace Vercel
{
    public partial interface IDeploymentsClient
    {
        /// <summary>
        /// Get Deployment File Contents<br/>
        /// Allows to retrieve the content of a file by supplying the file identifier and the deployment unique identifier. The response body will contain a JSON response containing the contents of the file encoded as base64.
        /// </summary>
        /// <param name="id">
        /// The unique deployment identifier
        /// </param>
        /// <param name="fileId">
        /// The unique file identifier
        /// </param>
        /// <param name="path">
        /// Path to the file to fetch (only for Git deployments)
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
        global::System.Threading.Tasks.Task GetDeploymentFileContentsAsync(
            string id,
            string fileId,
            string? path = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}