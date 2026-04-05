#nullable enable

namespace Vercel
{
    public partial interface IEdgeConfigClient
    {
        /// <summary>
        /// Delete one or more Edge Config tokens<br/>
        /// Deletes one or more tokens of an existing Edge Config.
        /// </summary>
        /// <param name="edgeConfigId"></param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteEdgeConfigTokensAsync(
            string edgeConfigId,

            global::Vercel.DeleteEdgeConfigTokensRequest request,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete one or more Edge Config tokens<br/>
        /// Deletes one or more tokens of an existing Edge Config.
        /// </summary>
        /// <param name="edgeConfigId"></param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="tokens"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task DeleteEdgeConfigTokensAsync(
            string edgeConfigId,
            global::System.Collections.Generic.IList<string> tokens,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}