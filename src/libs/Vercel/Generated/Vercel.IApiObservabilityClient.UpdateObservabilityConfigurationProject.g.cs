#nullable enable

namespace Vercel
{
    public partial interface IApiObservabilityClient
    {
        /// <summary>
        /// Updates a disabled Observability Plus project setting<br/>
        /// Updates whether Observability Plus is disabled for a single project.
        /// </summary>
        /// <param name="projectIdOrName">
        /// The ID or name of the project to update
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.UpdateObservabilityConfigurationProjectResponse> UpdateObservabilityConfigurationProjectAsync(
            string projectIdOrName,

            global::Vercel.UpdateObservabilityConfigurationProjectRequest request,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates a disabled Observability Plus project setting<br/>
        /// Updates whether Observability Plus is disabled for a single project.
        /// </summary>
        /// <param name="projectIdOrName">
        /// The ID or name of the project to update
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="disabled">
        /// Whether Observability Plus should be disabled for the project
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.UpdateObservabilityConfigurationProjectResponse> UpdateObservabilityConfigurationProjectAsync(
            string projectIdOrName,
            bool disabled,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}