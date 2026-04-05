#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Vercel
{
    public partial interface IAliasesClient
    {
        /// <summary>
        /// List aliases<br/>
        /// Retrieves a list of aliases for the authenticated User or Team. When `domain` is provided, only aliases for that domain will be returned. When `projectId` is provided, it will only return the given project aliases.
        /// </summary>
        /// <param name="domain">
        /// Get only aliases of the given domain name<br/>
        /// Example: my-test-domain.com
        /// </param>
        /// <param name="from">
        /// Get only aliases created after the provided timestamp<br/>
        /// Example: 1540095775951L
        /// </param>
        /// <param name="limit">
        /// Maximum number of aliases to list from a request<br/>
        /// Example: 10
        /// </param>
        /// <param name="projectId">
        /// Filter aliases from the given `projectId`<br/>
        /// Example: prj_12HKQaOmR5t5Uy6vdcQsNIiZgHGB
        /// </param>
        /// <param name="since">
        /// Get aliases created after this JavaScript timestamp<br/>
        /// Example: 1540095775941L
        /// </param>
        /// <param name="until">
        /// Get aliases created before this JavaScript timestamp<br/>
        /// Example: 1540095775951L
        /// </param>
        /// <param name="rollbackDeploymentId">
        /// Get aliases that would be rolled back for the given deployment<br/>
        /// Example: dpl_XXX
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.ListAliasesResponse> ListAliasesAsync(
            global::Vercel.OneOf<global::System.Collections.Generic.IList<string>, string>? domain = default,
            double? from = default,
            double? limit = default,
            string? projectId = default,
            double? since = default,
            double? until = default,
            string? rollbackDeploymentId = default,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}