#nullable enable

namespace Vercel
{
    public partial interface IFeatureFlagsClient
    {
        /// <summary>
        /// List attribute label counts<br/>
        /// List label counts for configured entity attributes, including empty ones.
        /// </summary>
        /// <param name="entityKind"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="cursor">
        /// The continuation cursor from the previous response.
        /// </param>
        /// <param name="projectIdOrName"></param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.ListFlagLabelCountsResponse> ListFlagLabelCountsAsync(
            string projectIdOrName,
            string? entityKind = default,
            int? limit = default,
            string? cursor = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List attribute label counts<br/>
        /// List label counts for configured entity attributes, including empty ones.
        /// </summary>
        /// <param name="entityKind"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="cursor">
        /// The continuation cursor from the previous response.
        /// </param>
        /// <param name="projectIdOrName"></param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.ListFlagLabelCountsResponse>> ListFlagLabelCountsAsResponseAsync(
            string projectIdOrName,
            string? entityKind = default,
            int? limit = default,
            string? cursor = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}