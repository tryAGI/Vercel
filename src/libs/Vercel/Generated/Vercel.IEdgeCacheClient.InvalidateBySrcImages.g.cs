#nullable enable

namespace Vercel
{
    public partial interface IEdgeCacheClient
    {
        /// <summary>
        /// Invalidate by source image<br/>
        /// Marks a source image as stale, causing its corresponding transformed images to be revalidated in the background on the next request.
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
        global::System.Threading.Tasks.Task InvalidateBySrcImagesAsync(
            string projectIdOrName,

            global::Vercel.InvalidateBySrcImagesRequest request,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Invalidate by source image<br/>
        /// Marks a source image as stale, causing its corresponding transformed images to be revalidated in the background on the next request.
        /// </summary>
        /// <param name="projectIdOrName"></param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="srcImages"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task InvalidateBySrcImagesAsync(
            string projectIdOrName,
            global::System.Collections.Generic.IList<string> srcImages,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}