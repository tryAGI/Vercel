#nullable enable

namespace Vercel
{
    public partial interface IEdgeConfigClient
    {
        /// <summary>
        /// Update Edge Config schema<br/>
        /// Update an Edge Config's schema.
        /// </summary>
        /// <param name="edgeConfigId"></param>
        /// <param name="dryRun"></param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> PatchEdgeConfigSchemaAsync(
            string edgeConfigId,

            global::Vercel.PatchEdgeConfigSchemaRequest request,
            string? dryRun = default,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Edge Config schema<br/>
        /// Update an Edge Config's schema.
        /// </summary>
        /// <param name="edgeConfigId"></param>
        /// <param name="dryRun"></param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="definition"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> PatchEdgeConfigSchemaAsync(
            string edgeConfigId,
            object definition,
            string? dryRun = default,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}