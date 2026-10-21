#nullable enable

namespace Vercel
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// List Organizations<br/>
        /// List the organizations where the authenticated user holds the OrgAdmin or OrgViewer permission on the organization's root or backing team — the same criteria as GET /v1/organizations/:organizationId/teams. A token without user scope, such as a team SSO session, lists only the organizations where it is authenticated to at least one team of the organization: the root team, the backing team, or a child team. This endpoint is in private beta. Contact your Vercel account team for access.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.ListOrganizationsResponse> ListOrganizationsAsync(
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Organizations<br/>
        /// List the organizations where the authenticated user holds the OrgAdmin or OrgViewer permission on the organization's root or backing team — the same criteria as GET /v1/organizations/:organizationId/teams. A token without user scope, such as a team SSO session, lists only the organizations where it is authenticated to at least one team of the organization: the root team, the backing team, or a child team. This endpoint is in private beta. Contact your Vercel account team for access.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.ListOrganizationsResponse>> ListOrganizationsAsResponseAsync(
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}