#nullable enable

namespace Vercel
{
    public partial interface IEdgeConfigClient
    {
        /// <summary>
        /// Get Edge Config backup<br/>
        /// Retrieves a specific version of an Edge Config from backup storage.
        /// </summary>
        /// <param name="edgeConfigId"></param>
        /// <param name="edgeConfigBackupVersionId"></param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.OneOf<global::Vercel.GetEdgeConfigBackupResponseVariant1, global::Vercel.GetEdgeConfigBackupResponseVariant2>> GetEdgeConfigBackupAsync(
            string edgeConfigId,
            string edgeConfigBackupVersionId,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}