#nullable enable

namespace Vercel
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// List drives<br/>
        /// Retrieves a paginated list of drives belonging to a specific project. Drives are in private beta. Register your interest to get access: https://vercel.com/changelog/drives-for-vercel-sandbox-in-private-beta
        /// </summary>
        /// <param name="projectId">
        /// The project ID or name associated with the drives. Required unless using a Vercel OIDC token scoped to a project.<br/>
        /// Example: prj_abc123
        /// </param>
        /// <param name="limit">
        /// Maximum number of drives to return in the response. Used for pagination.<br/>
        /// Default Value: 20<br/>
        /// Example: 20
        /// </param>
        /// <param name="cursor">
        /// Opaque pagination cursor from a previous response.
        /// </param>
        /// <param name="sortBy">
        /// Field to sort drives by.<br/>
        /// Default Value: createdAt
        /// </param>
        /// <param name="namePrefix">
        /// Filter drives whose name starts with this prefix. Only valid when sortBy=name.
        /// </param>
        /// <param name="sortOrder">
        /// Sort direction for results.<br/>
        /// Default Value: desc
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
        global::System.Threading.Tasks.Task<global::Vercel.ListDrivesResponse> ListDrivesAsync(
            string? projectId = default,
            double? limit = default,
            string? cursor = default,
            global::Vercel.ListDrivesSortBy? sortBy = default,
            string? namePrefix = default,
            global::Vercel.ListDrivesSortOrder? sortOrder = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List drives<br/>
        /// Retrieves a paginated list of drives belonging to a specific project. Drives are in private beta. Register your interest to get access: https://vercel.com/changelog/drives-for-vercel-sandbox-in-private-beta
        /// </summary>
        /// <param name="projectId">
        /// The project ID or name associated with the drives. Required unless using a Vercel OIDC token scoped to a project.<br/>
        /// Example: prj_abc123
        /// </param>
        /// <param name="limit">
        /// Maximum number of drives to return in the response. Used for pagination.<br/>
        /// Default Value: 20<br/>
        /// Example: 20
        /// </param>
        /// <param name="cursor">
        /// Opaque pagination cursor from a previous response.
        /// </param>
        /// <param name="sortBy">
        /// Field to sort drives by.<br/>
        /// Default Value: createdAt
        /// </param>
        /// <param name="namePrefix">
        /// Filter drives whose name starts with this prefix. Only valid when sortBy=name.
        /// </param>
        /// <param name="sortOrder">
        /// Sort direction for results.<br/>
        /// Default Value: desc
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
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.ListDrivesResponse>> ListDrivesAsResponseAsync(
            string? projectId = default,
            double? limit = default,
            string? cursor = default,
            global::Vercel.ListDrivesSortBy? sortBy = default,
            string? namePrefix = default,
            global::Vercel.ListDrivesSortOrder? sortOrder = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}