#nullable enable

namespace Vercel
{
    public partial interface IArtifactsClient
    {
        /// <summary>
        /// Get status of Remote Caching for this principal<br/>
        /// Check the status of Remote Caching for this principal. Returns a JSON-encoded status indicating if Remote Caching is enabled, disabled, or disabled due to usage limits.
        /// </summary>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.OneOf<global::Vercel.StatusResponseVariant1, global::Vercel.StatusResponseVariant2>> StatusAsync(
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}