#nullable enable

namespace Vercel
{
    public partial interface IAccessGroupsClient
    {
        /// <summary>
        /// List members of an access group<br/>
        /// List members of an access group
        /// </summary>
        /// <param name="idOrName">
        /// The ID or name of the Access Group.<br/>
        /// Example: ag_pavWOn1iLObbXLRiwVvzmPrTWyTf
        /// </param>
        /// <param name="limit">
        /// Limit how many access group members should be returned.<br/>
        /// Example: 20
        /// </param>
        /// <param name="next">
        /// Continuation cursor to retrieve the next page of results.
        /// </param>
        /// <param name="search">
        /// Search project members by their name, username, and email.
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
        global::System.Threading.Tasks.Task<global::Vercel.ListAccessGroupMembersResponse> ListAccessGroupMembersAsync(
            string idOrName,
            int? limit = default,
            string? next = default,
            string? search = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}