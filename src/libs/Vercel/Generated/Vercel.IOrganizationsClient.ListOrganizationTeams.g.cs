#nullable enable

namespace Vercel
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// List Organization Teams<br/>
        /// List up to 100 teams in an organization, each enriched with the team's slug, name, and avatar. Set `includeMemberCount` to include counts that include pending memberships but exclude email invitations without a membership record. Teams whose underlying record no longer exists are omitted, so a page may contain fewer teams than the page size (or be empty) while still returning a `cursor`; paginate until `cursor` is absent. This endpoint is in private beta. Contact your Vercel account team for access.
        /// </summary>
        /// <param name="organizationId">
        /// The ID of the organization.
        /// </param>
        /// <param name="cursor">
        /// Pagination cursor.
        /// </param>
        /// <param name="includeMemberCount">
        /// When true, includes each team's member count in the response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.ListOrganizationTeamsResponse> ListOrganizationTeamsAsync(
            string organizationId,
            string? cursor = default,
            bool? includeMemberCount = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Organization Teams<br/>
        /// List up to 100 teams in an organization, each enriched with the team's slug, name, and avatar. Set `includeMemberCount` to include counts that include pending memberships but exclude email invitations without a membership record. Teams whose underlying record no longer exists are omitted, so a page may contain fewer teams than the page size (or be empty) while still returning a `cursor`; paginate until `cursor` is absent. This endpoint is in private beta. Contact your Vercel account team for access.
        /// </summary>
        /// <param name="organizationId">
        /// The ID of the organization.
        /// </param>
        /// <param name="cursor">
        /// Pagination cursor.
        /// </param>
        /// <param name="includeMemberCount">
        /// When true, includes each team's member count in the response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.ListOrganizationTeamsResponse>> ListOrganizationTeamsAsResponseAsync(
            string organizationId,
            string? cursor = default,
            bool? includeMemberCount = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}