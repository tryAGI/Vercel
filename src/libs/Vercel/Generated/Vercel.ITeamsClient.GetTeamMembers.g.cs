#nullable enable

namespace Vercel
{
    public partial interface ITeamsClient
    {
        /// <summary>
        /// List team members<br/>
        /// Get a paginated list of team members for the provided team.
        /// </summary>
        /// <param name="limit">
        /// Limit how many teams should be returned<br/>
        /// Example: 20
        /// </param>
        /// <param name="since">
        /// Timestamp in milliseconds to only include members added since then.<br/>
        /// Example: 1540095775951L
        /// </param>
        /// <param name="until">
        /// Timestamp in milliseconds to only include members added until then.<br/>
        /// Example: 1540095775951L
        /// </param>
        /// <param name="search">
        /// Search team members by their name, username, and email.
        /// </param>
        /// <param name="role">
        /// Only return members with the specified team role.<br/>
        /// Example: OWNER
        /// </param>
        /// <param name="excludeProject">
        /// Exclude members who belong to the specified project.
        /// </param>
        /// <param name="eligibleMembersForProjectId">
        /// Include team members who are eligible to be members of the specified project.
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
        global::System.Threading.Tasks.Task<global::Vercel.GetTeamMembersResponse> GetTeamMembersAsync(
            string teamId,
            double? limit = default,
            double? since = default,
            double? until = default,
            string? search = default,
            global::Vercel.GetTeamMembersRole? role = default,
            string? excludeProject = default,
            string? eligibleMembersForProjectId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}