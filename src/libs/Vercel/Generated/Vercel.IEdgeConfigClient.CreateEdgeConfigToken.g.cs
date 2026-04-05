#nullable enable

namespace Vercel
{
    public partial interface IEdgeConfigClient
    {
        /// <summary>
        /// Create an Edge Config token<br/>
        /// Adds a token to an existing Edge Config.
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
        global::System.Threading.Tasks.Task<global::Vercel.CreateEdgeConfigTokenResponse> CreateEdgeConfigTokenAsync(
            string edgeConfigId,

            global::Vercel.CreateEdgeConfigTokenRequest request,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an Edge Config token<br/>
        /// Adds a token to an existing Edge Config.
        /// </summary>
        /// <param name="edgeConfigId"></param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="label"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.CreateEdgeConfigTokenResponse> CreateEdgeConfigTokenAsync(
            string edgeConfigId,
            string label,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}