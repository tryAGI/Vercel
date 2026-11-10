#nullable enable

namespace Vercel
{
    public partial interface IDrivesClient
    {
        /// <summary>
        /// Fork a drive<br/>
        /// Fork the provided drive into a new one with the provided name, inheriting the region and max size.
        /// </summary>
        /// <param name="name">
        /// Name of the source drive to fork.<br/>
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
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.ForkDriveV1Response> ForkDriveV1Async(
            string name,

            global::Vercel.ForkDriveV1Request request,
            string? projectId = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Fork a drive<br/>
        /// Fork the provided drive into a new one with the provided name, inheriting the region and max size.
        /// </summary>
        /// <param name="name">
        /// Name of the source drive to fork.<br/>
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
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.ForkDriveV1Response>> ForkDriveV1AsResponseAsync(
            string name,

            global::Vercel.ForkDriveV1Request request,
            string? projectId = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Fork a drive<br/>
        /// Fork the provided drive into a new one with the provided name, inheriting the region and max size.
        /// </summary>
        /// <param name="name">
        /// Name of the source drive to fork.<br/>
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
        /// <param name="requestName">
        /// Name for the forked drive. Must be unique per project and URL-safe (alphanumeric, hyphens, underscores).<br/>
        /// Example: workspace-fork
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.ForkDriveV1Response> ForkDriveV1Async(
            string name,
            string requestName,
            string? projectId = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}