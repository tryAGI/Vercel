#nullable enable

namespace Vercel
{
    public partial interface IVercelCiClient
    {
        /// <summary>
        /// List invocations for a team, optionally filtered by repository and invocation metadata<br/>
        /// List Invocations
        /// </summary>
        /// <param name="provider">
        /// Repository provider (e.g., \"github\").
        /// </param>
        /// <param name="repository">
        /// Repository slug (e.g., \"vercel/next.js\").
        /// </param>
        /// <param name="branchName">
        /// Branch name (e.g., \"main\").
        /// </param>
        /// <param name="snapshot">
        /// Snapshot/commit hash.
        /// </param>
        /// <param name="status"></param>
        /// <param name="conclusion"></param>
        /// <param name="source"></param>
        /// <param name="authorGitHubId"></param>
        /// <param name="author">
        /// GitHub author login.
        /// </param>
        /// <param name="createdAfter"></param>
        /// <param name="createdBefore"></param>
        /// <param name="limit">
        /// Number of results per page (default: 20, max: 100).
        /// </param>
        /// <param name="cursor">
        /// Pagination cursor from a previous response.
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
        global::System.Threading.Tasks.Task<global::Vercel.ListVercelCiInvocationsResponse> ListVercelCiInvocationsAsync(
            global::Vercel.ListVercelCiInvocationsProvider? provider = default,
            string? repository = default,
            string? branchName = default,
            string? snapshot = default,
            global::System.Collections.Generic.IList<global::Vercel.ListVercelCiInvocationsStatu>? status = default,
            global::System.Collections.Generic.IList<global::Vercel.ListVercelCiInvocationsConclusionItem>? conclusion = default,
            global::System.Collections.Generic.IList<global::Vercel.ListVercelCiInvocationsSourceItem>? source = default,
            string? authorGitHubId = default,
            string? author = default,
            double? createdAfter = default,
            double? createdBefore = default,
            double? limit = default,
            string? cursor = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List invocations for a team, optionally filtered by repository and invocation metadata<br/>
        /// List Invocations
        /// </summary>
        /// <param name="provider">
        /// Repository provider (e.g., \"github\").
        /// </param>
        /// <param name="repository">
        /// Repository slug (e.g., \"vercel/next.js\").
        /// </param>
        /// <param name="branchName">
        /// Branch name (e.g., \"main\").
        /// </param>
        /// <param name="snapshot">
        /// Snapshot/commit hash.
        /// </param>
        /// <param name="status"></param>
        /// <param name="conclusion"></param>
        /// <param name="source"></param>
        /// <param name="authorGitHubId"></param>
        /// <param name="author">
        /// GitHub author login.
        /// </param>
        /// <param name="createdAfter"></param>
        /// <param name="createdBefore"></param>
        /// <param name="limit">
        /// Number of results per page (default: 20, max: 100).
        /// </param>
        /// <param name="cursor">
        /// Pagination cursor from a previous response.
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
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.ListVercelCiInvocationsResponse>> ListVercelCiInvocationsAsResponseAsync(
            global::Vercel.ListVercelCiInvocationsProvider? provider = default,
            string? repository = default,
            string? branchName = default,
            string? snapshot = default,
            global::System.Collections.Generic.IList<global::Vercel.ListVercelCiInvocationsStatu>? status = default,
            global::System.Collections.Generic.IList<global::Vercel.ListVercelCiInvocationsConclusionItem>? conclusion = default,
            global::System.Collections.Generic.IList<global::Vercel.ListVercelCiInvocationsSourceItem>? source = default,
            string? authorGitHubId = default,
            string? author = default,
            double? createdAfter = default,
            double? createdBefore = default,
            double? limit = default,
            string? cursor = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}