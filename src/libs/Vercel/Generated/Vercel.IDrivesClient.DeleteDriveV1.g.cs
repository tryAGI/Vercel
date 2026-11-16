#nullable enable

namespace Vercel
{
    public partial interface IDrivesClient
    {
        /// <summary>
        /// Delete a drive<br/>
        /// Deletes a drive by project and name or drive ID. Attached drives cannot be deleted. Stop or replace the session currently using the drive before retrying deletion.
        /// </summary>
        /// <param name="nameOrId">
        /// The drive name or ID.<br/>
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
        global::System.Threading.Tasks.Task<global::Vercel.DeleteDriveV1Response> DeleteDriveV1Async(
            string nameOrId,
            string? projectId = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a drive<br/>
        /// Deletes a drive by project and name or drive ID. Attached drives cannot be deleted. Stop or replace the session currently using the drive before retrying deletion.
        /// </summary>
        /// <param name="nameOrId">
        /// The drive name or ID.<br/>
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
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.DeleteDriveV1Response>> DeleteDriveV1AsResponseAsync(
            string nameOrId,
            string? projectId = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}