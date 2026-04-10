#nullable enable

namespace Vercel
{
    public partial interface IAliasesClient
    {
        /// <summary>
        /// List Deployment Aliases<br/>
        /// Retrieves all Aliases for the Deployment with the given ID. The authenticated user or team must own the deployment.
        /// </summary>
        /// <param name="id">
        /// The ID of the deployment the aliases should be listed for<br/>
        /// Example: dpl_FjvFJncQHQcZMznrUm9EoB8sFuPa
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
        global::System.Threading.Tasks.Task<global::Vercel.ListDeploymentAliasesResponse> ListDeploymentAliasesAsync(
            string id,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}