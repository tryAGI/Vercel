#nullable enable

namespace Vercel
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Update Organization Team Directory Sync Mode<br/>
        /// Select whether one Organization team's memberships are governed by the Organization's Directory Sync or by the team's own directory. The team's own directory connection is kept either way. The root team can follow the Organization's Directory Sync only when no group grants OrgAdmin or at least one OrgAdmin group also grants the Owner role on it.
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="targetTeamId"></param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.PutOrganizationTeamDsyncResponse> PutOrganizationTeamDsyncAsync(
            string organizationId,
            string targetTeamId,

            global::Vercel.PutOrganizationTeamDsyncRequest request,
            string? slug = default,
            string? teamId = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Organization Team Directory Sync Mode<br/>
        /// Select whether one Organization team's memberships are governed by the Organization's Directory Sync or by the team's own directory. The team's own directory connection is kept either way. The root team can follow the Organization's Directory Sync only when no group grants OrgAdmin or at least one OrgAdmin group also grants the Owner role on it.
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="targetTeamId"></param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.PutOrganizationTeamDsyncResponse>> PutOrganizationTeamDsyncAsResponseAsync(
            string organizationId,
            string targetTeamId,

            global::Vercel.PutOrganizationTeamDsyncRequest request,
            string? slug = default,
            string? teamId = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Organization Team Directory Sync Mode<br/>
        /// Select whether one Organization team's memberships are governed by the Organization's Directory Sync or by the team's own directory. The team's own directory connection is kept either way. The root team can follow the Organization's Directory Sync only when no group grants OrgAdmin or at least one OrgAdmin group also grants the Owner role on it.
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="targetTeamId"></param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="dsyncMode">
        /// Whether the Organization's Directory Sync or the team's own directory governs the team's memberships.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.PutOrganizationTeamDsyncResponse> PutOrganizationTeamDsyncAsync(
            string organizationId,
            string targetTeamId,
            global::Vercel.PutOrganizationTeamDsyncRequestDsyncMode dsyncMode,
            string? slug = default,
            string? teamId = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}