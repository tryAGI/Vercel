#nullable enable

namespace Vercel
{
    public partial interface IEdgeCacheClient
    {
        /// <summary>
        /// Dangerously delete by tag<br/>
        /// Marks a cache tag as deleted, causing cache entries associated with that tag to be revalidated in the foreground on the next request. Use this method with caution because one tag can be associated with many paths and deleting the cache can cause many concurrent requests to the origin leading to cache stampede problem. This method is for advanced use cases and is not recommended; prefer using `invalidateByTag` instead.
        /// </summary>
        /// <param name="projectIdOrName"></param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task DangerouslyDeleteByTagsAsync(
            string projectIdOrName,

            global::Vercel.DangerouslyDeleteByTagsRequest request,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Dangerously delete by tag<br/>
        /// Marks a cache tag as deleted, causing cache entries associated with that tag to be revalidated in the foreground on the next request. Use this method with caution because one tag can be associated with many paths and deleting the cache can cause many concurrent requests to the origin leading to cache stampede problem. This method is for advanced use cases and is not recommended; prefer using `invalidateByTag` instead.
        /// </summary>
        /// <param name="projectIdOrName"></param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="revalidationDeadlineSeconds"></param>
        /// <param name="tags"></param>
        /// <param name="target"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task DangerouslyDeleteByTagsAsync(
            string projectIdOrName,
            global::Vercel.OneOf<global::System.Collections.Generic.IList<string>, string> tags,
            string? teamId = default,
            string? slug = default,
            double? revalidationDeadlineSeconds = default,
            global::Vercel.DangerouslyDeleteByTagsRequestTarget? target = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}