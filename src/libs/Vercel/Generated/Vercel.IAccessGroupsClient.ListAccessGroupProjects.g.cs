#nullable enable

namespace Vercel
{
    public partial interface IAccessGroupsClient
    {
        /// <summary>
        /// List projects of an access group<br/>
        /// List projects of an access group
        /// </summary>
        /// <param name="idOrName">
        /// The ID or name of the Access Group.<br/>
        /// Example: ag_pavWOn1iLObbXLRiwVvzmPrTWyTf
        /// </param>
        /// <param name="limit">
        /// Limit how many access group projects should be returned.<br/>
        /// Example: 20
        /// </param>
        /// <param name="next">
        /// Continuation cursor to retrieve the next page of results.
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.ListAccessGroupProjectsResponse> ListAccessGroupProjectsAsync(
            string idOrName,
            int? limit = default,
            string? next = default,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}