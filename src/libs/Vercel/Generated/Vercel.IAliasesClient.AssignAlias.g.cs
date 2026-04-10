#nullable enable

namespace Vercel
{
    public partial interface IAliasesClient
    {
        /// <summary>
        /// Assign an Alias<br/>
        /// Creates a new alias for the deployment with the given deployment ID. The authenticated user or team must own this deployment. If the desired alias is already assigned to another deployment, then it will be removed from the old deployment and assigned to the new one.
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
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.AssignAliasResponse> AssignAliasAsync(
            string id,

            global::Vercel.AssignAliasRequest request,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Assign an Alias<br/>
        /// Creates a new alias for the deployment with the given deployment ID. The authenticated user or team must own this deployment. If the desired alias is already assigned to another deployment, then it will be removed from the old deployment and assigned to the new one.
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
        /// <param name="alias">
        /// The alias we want to assign to the deployment defined in the URL<br/>
        /// Example: my-alias.vercel.app
        /// </param>
        /// <param name="redirect">
        /// The redirect property will take precedence over the deployment id from the URL and consists of a hostname (like test.com) to which the alias should redirect using status code 307<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.AssignAliasResponse> AssignAliasAsync(
            string id,
            string? teamId = default,
            string? slug = default,
            string? alias = default,
            string? redirect = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}