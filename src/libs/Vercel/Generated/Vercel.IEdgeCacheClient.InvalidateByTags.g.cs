#nullable enable

namespace Vercel
{
    public partial interface IEdgeCacheClient
    {
        /// <summary>
        /// Invalidate by tag<br/>
        /// Marks a cache tag as stale, causing cache entries associated with that tag to be revalidated in the background on the next request.
        /// </summary>
        /// <param name="projectIdOrName"></param>
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
        global::System.Threading.Tasks.Task InvalidateByTagsAsync(
            string projectIdOrName,

            global::Vercel.InvalidateByTagsRequest request,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Invalidate by tag<br/>
        /// Marks a cache tag as stale, causing cache entries associated with that tag to be revalidated in the background on the next request.
        /// </summary>
        /// <param name="projectIdOrName"></param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="tags"></param>
        /// <param name="target"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task InvalidateByTagsAsync(
            string projectIdOrName,
            global::Vercel.OneOf<global::System.Collections.Generic.IList<string>, string> tags,
            string? teamId = default,
            string? slug = default,
            global::Vercel.InvalidateByTagsRequestTarget? target = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}