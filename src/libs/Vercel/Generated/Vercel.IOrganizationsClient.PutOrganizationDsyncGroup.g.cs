#nullable enable

namespace Vercel
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Create or Replace Organization Directory Sync Group Configuration<br/>
        /// Create or replace one organization's Directory Sync group configuration. The directory starts syncing when at least one group grants OrgAdmin. A group that grants OrgAdmin must also grant the Owner role on the organization's root team, as its default role or for that team. A save that would leave the root team without an owner, or take the Owner role on it from the acting admin, is refused with `organization_lockout` unless `overrideLockout` is set.
        /// </summary>
        /// <param name="ifMatch"></param>
        /// <param name="ifNoneMatch"></param>
        /// <param name="organizationId"></param>
        /// <param name="groupId"></param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.OrganizationDirectorySyncGroup> PutOrganizationDsyncGroupAsync(
            string organizationId,
            string groupId,

            global::Vercel.PutOrganizationDsyncGroupRequest request,
            string? ifMatch = default,
            string? ifNoneMatch = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create or Replace Organization Directory Sync Group Configuration<br/>
        /// Create or replace one organization's Directory Sync group configuration. The directory starts syncing when at least one group grants OrgAdmin. A group that grants OrgAdmin must also grant the Owner role on the organization's root team, as its default role or for that team. A save that would leave the root team without an owner, or take the Owner role on it from the acting admin, is refused with `organization_lockout` unless `overrideLockout` is set.
        /// </summary>
        /// <param name="ifMatch"></param>
        /// <param name="ifNoneMatch"></param>
        /// <param name="organizationId"></param>
        /// <param name="groupId"></param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.OrganizationDirectorySyncGroup>> PutOrganizationDsyncGroupAsResponseAsync(
            string organizationId,
            string groupId,

            global::Vercel.PutOrganizationDsyncGroupRequest request,
            string? ifMatch = default,
            string? ifNoneMatch = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create or Replace Organization Directory Sync Group Configuration<br/>
        /// Create or replace one organization's Directory Sync group configuration. The directory starts syncing when at least one group grants OrgAdmin. A group that grants OrgAdmin must also grant the Owner role on the organization's root team, as its default role or for that team. A save that would leave the root team without an owner, or take the Owner role on it from the acting admin, is refused with `organization_lockout` unless `overrideLockout` is set.
        /// </summary>
        /// <param name="ifMatch"></param>
        /// <param name="ifNoneMatch"></param>
        /// <param name="organizationId"></param>
        /// <param name="groupId"></param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="assignments"></param>
        /// <param name="overrideLockout">
        /// Save even if the change would leave the root team without an owner or the acting admin without the Owner role on it.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.OrganizationDirectorySyncGroup> PutOrganizationDsyncGroupAsync(
            string organizationId,
            string groupId,
            global::Vercel.PutOrganizationDsyncGroupRequestAssignments assignments,
            string? ifMatch = default,
            string? ifNoneMatch = default,
            string? teamId = default,
            string? slug = default,
            bool? overrideLockout = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}