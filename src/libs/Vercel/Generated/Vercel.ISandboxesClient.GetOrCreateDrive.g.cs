#nullable enable

namespace Vercel
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Get or create a drive<br/>
        /// Gets an existing drive by project and name, or creates it when it does not exist. Drives are in private beta. Register your interest to get access: https://vercel.com/changelog/drives-for-vercel-sandbox-in-private-beta
        /// </summary>
        /// <param name="name">
        /// Name for the drive. Must be unique per project and URL-safe (alphanumeric, hyphens, underscores).<br/>
        /// Example: workspace
        /// </param>
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
        global::System.Threading.Tasks.Task<global::Vercel.GetOrCreateDriveResponse> GetOrCreateDriveAsync(
            string name,

            global::Vercel.GetOrCreateDriveRequest request,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get or create a drive<br/>
        /// Gets an existing drive by project and name, or creates it when it does not exist. Drives are in private beta. Register your interest to get access: https://vercel.com/changelog/drives-for-vercel-sandbox-in-private-beta
        /// </summary>
        /// <param name="name">
        /// Name for the drive. Must be unique per project and URL-safe (alphanumeric, hyphens, underscores).<br/>
        /// Example: workspace
        /// </param>
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
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.GetOrCreateDriveResponse>> GetOrCreateDriveAsResponseAsync(
            string name,

            global::Vercel.GetOrCreateDriveRequest request,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get or create a drive<br/>
        /// Gets an existing drive by project and name, or creates it when it does not exist. Drives are in private beta. Register your interest to get access: https://vercel.com/changelog/drives-for-vercel-sandbox-in-private-beta
        /// </summary>
        /// <param name="name">
        /// Name for the drive. Must be unique per project and URL-safe (alphanumeric, hyphens, underscores).<br/>
        /// Example: workspace
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="projectId">
        /// The project ID or name to associate the drive with. Required unless using a Vercel OIDC token scoped to a project.<br/>
        /// Example: prj_abc123
        /// </param>
        /// <param name="maxSizeBytes">
        /// Maximum drive size in bytes. Defaults to 100 GiB when omitted.
        /// </param>
        /// <param name="region">
        /// Region where the drive is stored. Defaults to iad1.<br/>
        /// Default Value: iad1<br/>
        /// Example: iad1
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.GetOrCreateDriveResponse> GetOrCreateDriveAsync(
            string name,
            string? teamId = default,
            string? slug = default,
            string? projectId = default,
            int? maxSizeBytes = default,
            global::Vercel.GetOrCreateDriveRequestRegion? region = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}