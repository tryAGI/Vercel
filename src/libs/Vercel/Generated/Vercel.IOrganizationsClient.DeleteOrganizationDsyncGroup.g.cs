#nullable enable

namespace Vercel
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Delete Organization Directory Sync Group Configuration<br/>
        /// Delete one organization's Directory Sync group configuration. The last group granting OrgAdmin cannot be removed. A deletion that would leave the root team without an owner, or take the Owner role on it from the acting admin, is refused with `organization_lockout` unless `overrideLockout` is set.
        /// </summary>
        /// <param name="ifMatch"></param>
        /// <param name="organizationId"></param>
        /// <param name="groupId"></param>
        /// <param name="overrideLockout">
        /// Delete even if it would leave the root team without an owner or the acting admin without the Owner role on it.
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
        global::System.Threading.Tasks.Task DeleteOrganizationDsyncGroupAsync(
            string organizationId,
            string groupId,
            string? ifMatch = default,
            bool? overrideLockout = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Organization Directory Sync Group Configuration<br/>
        /// Delete one organization's Directory Sync group configuration. The last group granting OrgAdmin cannot be removed. A deletion that would leave the root team without an owner, or take the Owner role on it from the acting admin, is refused with `organization_lockout` unless `overrideLockout` is set.
        /// </summary>
        /// <param name="ifMatch"></param>
        /// <param name="organizationId"></param>
        /// <param name="groupId"></param>
        /// <param name="overrideLockout">
        /// Delete even if it would leave the root team without an owner or the acting admin without the Owner role on it.
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
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse> DeleteOrganizationDsyncGroupAsResponseAsync(
            string organizationId,
            string groupId,
            string? ifMatch = default,
            bool? overrideLockout = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}