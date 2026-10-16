#nullable enable

namespace Vercel
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Delete Team from Organization<br/>
        /// Delete a team from an organization. This endpoint is in private beta. Contact your Vercel account team for access.
        /// </summary>
        /// <param name="organizationId">
        /// The ID of the organization.
        /// </param>
        /// <param name="targetTeamId">
        /// The ID of the team to remove.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.RemoveOrganizationTeamResponse> RemoveOrganizationTeamAsync(
            string organizationId,
            string targetTeamId,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Team from Organization<br/>
        /// Delete a team from an organization. This endpoint is in private beta. Contact your Vercel account team for access.
        /// </summary>
        /// <param name="organizationId">
        /// The ID of the organization.
        /// </param>
        /// <param name="targetTeamId">
        /// The ID of the team to remove.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.RemoveOrganizationTeamResponse>> RemoveOrganizationTeamAsResponseAsync(
            string organizationId,
            string targetTeamId,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}