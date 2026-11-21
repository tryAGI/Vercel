#nullable enable

namespace Vercel
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// List Organization Directory Sync Groups<br/>
        /// List the groups in an organization's Identity Provider directory, along with their Directory Sync group configuration when one exists.
        /// </summary>
        /// <param name="organizationId">
        /// The ID of the organization.
        /// </param>
        /// <param name="cursor">
        /// Pagination cursor.
        /// </param>
        /// <param name="limit">
        /// Number of groups to return.
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
        global::System.Threading.Tasks.Task<global::Vercel.ListOrganizationDsyncGroupsResponse> ListOrganizationDsyncGroupsAsync(
            string organizationId,
            string? cursor = default,
            double? limit = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Organization Directory Sync Groups<br/>
        /// List the groups in an organization's Identity Provider directory, along with their Directory Sync group configuration when one exists.
        /// </summary>
        /// <param name="organizationId">
        /// The ID of the organization.
        /// </param>
        /// <param name="cursor">
        /// Pagination cursor.
        /// </param>
        /// <param name="limit">
        /// Number of groups to return.
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
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.ListOrganizationDsyncGroupsResponse>> ListOrganizationDsyncGroupsAsResponseAsync(
            string organizationId,
            string? cursor = default,
            double? limit = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}