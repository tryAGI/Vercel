#nullable enable

namespace Vercel
{
    public partial interface IFeatureFlagsClient
    {
        /// <summary>
        /// List attribute labels<br/>
        /// List labels for one entity attribute. Search can return a short or empty page with a continuation cursor; continue until pagination.next is null.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="cursor">
        /// The continuation cursor from the previous response.
        /// </param>
        /// <param name="search">
        /// Case-insensitive substring search on the value and label.
        /// </param>
        /// <param name="entityKind"></param>
        /// <param name="attributeKey"></param>
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
        global::System.Threading.Tasks.Task<global::Vercel.ListFlagLabelsResponse> ListFlagLabelsAsync(
            string entityKind,
            string attributeKey,
            string projectIdOrName,
            int? limit = default,
            string? cursor = default,
            string? search = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List attribute labels<br/>
        /// List labels for one entity attribute. Search can return a short or empty page with a continuation cursor; continue until pagination.next is null.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="cursor">
        /// The continuation cursor from the previous response.
        /// </param>
        /// <param name="search">
        /// Case-insensitive substring search on the value and label.
        /// </param>
        /// <param name="entityKind"></param>
        /// <param name="attributeKey"></param>
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
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.ListFlagLabelsResponse>> ListFlagLabelsAsResponseAsync(
            string entityKind,
            string attributeKey,
            string projectIdOrName,
            int? limit = default,
            string? cursor = default,
            string? search = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}