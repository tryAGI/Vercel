#nullable enable

namespace Vercel
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Delete a drive<br/>
        /// Deletes a drive by project and name. Attached drives cannot be deleted. Stop or replace the session currently using the drive before retrying deletion. Drives are in private beta. Register your interest to get access: https://vercel.com/changelog/drives-for-vercel-sandbox-in-private-beta
        /// </summary>
        /// <param name="name">
        /// Name for the drive. Must be unique per project and URL-safe (alphanumeric, hyphens, underscores).<br/>
        /// Example: workspace
        /// </param>
        /// <param name="projectId">
        /// The project ID or name associated with the drive. Required unless using a Vercel OIDC token scoped to a project.<br/>
        /// Example: prj_abc123
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
        global::System.Threading.Tasks.Task<global::Vercel.DeleteDriveResponse> DeleteDriveAsync(
            string name,
            string? projectId = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a drive<br/>
        /// Deletes a drive by project and name. Attached drives cannot be deleted. Stop or replace the session currently using the drive before retrying deletion. Drives are in private beta. Register your interest to get access: https://vercel.com/changelog/drives-for-vercel-sandbox-in-private-beta
        /// </summary>
        /// <param name="name">
        /// Name for the drive. Must be unique per project and URL-safe (alphanumeric, hyphens, underscores).<br/>
        /// Example: workspace
        /// </param>
        /// <param name="projectId">
        /// The project ID or name associated with the drive. Required unless using a Vercel OIDC token scoped to a project.<br/>
        /// Example: prj_abc123
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
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.DeleteDriveResponse>> DeleteDriveAsResponseAsync(
            string name,
            string? projectId = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}