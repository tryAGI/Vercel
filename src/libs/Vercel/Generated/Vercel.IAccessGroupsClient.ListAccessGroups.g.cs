#nullable enable

namespace Vercel
{
    public partial interface IAccessGroupsClient
    {
        /// <summary>
        /// List access groups for a team, project or member<br/>
        /// List access groups
        /// </summary>
        /// <param name="projectId">
        /// Filter access groups by project.<br/>
        /// Example: prj_pavWOn1iLObbx3RowVvzmPrTWyTf
        /// </param>
        /// <param name="search">
        /// Search for access groups by name.<br/>
        /// Example: example
        /// </param>
        /// <param name="membersLimit">
        /// Number of members to include in the response.<br/>
        /// Example: 20
        /// </param>
        /// <param name="projectsLimit">
        /// Number of projects to include in the response.<br/>
        /// Example: 20
        /// </param>
        /// <param name="limit">
        /// Limit how many access group should be returned.<br/>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.OneOf<object, global::Vercel.ListAccessGroupsResponseVariant2>> ListAccessGroupsAsync(
            string? projectId = default,
            string? search = default,
            int? membersLimit = default,
            int? projectsLimit = default,
            int? limit = default,
            string? next = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}