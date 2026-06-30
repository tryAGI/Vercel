#nullable enable

namespace Vercel
{
    public partial interface IDeploymentsClient
    {
        /// <summary>
        /// Cancel a deployment<br/>
        /// Cancels a deployment that is currently in progress, stopping the build before it completes. Use this to recover quickly from accidental deploys, wrong-branch pushes, or builds with known errors — without waiting for them to finish. Returns 400 if the deployment is no longer cancelable (already `READY`, `ERROR`, or `CANCELED`). Returns the updated deployment object with `readyState: 'CANCELED'` on success.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the deployment.<br/>
        /// Example: dpl_5WJWYSyB7BpgTj3EuwF37WMRBXBtPQ2iTMJHJBJyRfd
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
        global::System.Threading.Tasks.Task<global::Vercel.CancelDeploymentResponse> CancelDeploymentAsync(
            string id,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Cancel a deployment<br/>
        /// Cancels a deployment that is currently in progress, stopping the build before it completes. Use this to recover quickly from accidental deploys, wrong-branch pushes, or builds with known errors — without waiting for them to finish. Returns 400 if the deployment is no longer cancelable (already `READY`, `ERROR`, or `CANCELED`). Returns the updated deployment object with `readyState: 'CANCELED'` on success.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the deployment.<br/>
        /// Example: dpl_5WJWYSyB7BpgTj3EuwF37WMRBXBtPQ2iTMJHJBJyRfd
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
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.CancelDeploymentResponse>> CancelDeploymentAsResponseAsync(
            string id,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}