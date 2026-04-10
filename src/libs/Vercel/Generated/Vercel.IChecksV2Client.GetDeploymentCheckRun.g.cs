#nullable enable

namespace Vercel
{
    public partial interface IChecksV2Client
    {
        /// <summary>
        /// Get a check run<br/>
        /// Return a detailed response for a single check run.
        /// </summary>
        /// <param name="deploymentId"></param>
        /// <param name="checkRunId">
        /// The ID of the resource that will be updated.<br/>
        /// Example: ckr_89ha9sdhh9a9
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
        global::System.Threading.Tasks.Task<global::Vercel.GetDeploymentCheckRunResponse> GetDeploymentCheckRunAsync(
            string deploymentId,
            string checkRunId,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}