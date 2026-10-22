#nullable enable

namespace Vercel
{
    public partial interface INetworkingClient
    {
        /// <summary>
        /// Delete a PrivateLink endpoint<br/>
        /// Deletes a PrivateLink endpoint. The endpoint is removed asynchronously. Repeating the request for an endpoint that is already being deleted retries its cleanup and also returns `204`. Changes to endpoints of the same project are serialized. If another change holds them for too long, the request fails with `503 service_unavailable` and can be retried. If the change may have completed but the outcome is unknown, it fails with `409 uncertain_outcome`; read the endpoint before retrying.
        /// </summary>
        /// <param name="projectId">
        /// The project ID the PrivateLink endpoint belongs to.<br/>
        /// Example: prj_a1b2c3d4e5f6g7h8
        /// </param>
        /// <param name="endpointId">
        /// The unique identifier of the PrivateLink endpoint.<br/>
        /// Example: ple_a1b2c3d4e5f6g7h8
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
        global::System.Threading.Tasks.Task<string> DeletePrivateLinkEndpointAsync(
            string projectId,
            string endpointId,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a PrivateLink endpoint<br/>
        /// Deletes a PrivateLink endpoint. The endpoint is removed asynchronously. Repeating the request for an endpoint that is already being deleted retries its cleanup and also returns `204`. Changes to endpoints of the same project are serialized. If another change holds them for too long, the request fails with `503 service_unavailable` and can be retried. If the change may have completed but the outcome is unknown, it fails with `409 uncertain_outcome`; read the endpoint before retrying.
        /// </summary>
        /// <param name="projectId">
        /// The project ID the PrivateLink endpoint belongs to.<br/>
        /// Example: prj_a1b2c3d4e5f6g7h8
        /// </param>
        /// <param name="endpointId">
        /// The unique identifier of the PrivateLink endpoint.<br/>
        /// Example: ple_a1b2c3d4e5f6g7h8
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
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<string>> DeletePrivateLinkEndpointAsResponseAsync(
            string projectId,
            string endpointId,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}