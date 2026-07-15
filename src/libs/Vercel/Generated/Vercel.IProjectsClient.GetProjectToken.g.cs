#nullable enable

namespace Vercel
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Generate a project OIDC token<br/>
        /// Generates an OIDC token for the project and returns it.
        /// </summary>
        /// <param name="idOrName">
        /// The project ID or name<br/>
        /// Example: my-project, &lt;prj_id&gt;
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
        global::System.Threading.Tasks.Task<global::Vercel.GetProjectTokenResponse> GetProjectTokenAsync(
            string idOrName,

            global::Vercel.GetProjectTokenRequest request,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate a project OIDC token<br/>
        /// Generates an OIDC token for the project and returns it.
        /// </summary>
        /// <param name="idOrName">
        /// The project ID or name<br/>
        /// Example: my-project, &lt;prj_id&gt;
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
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.GetProjectTokenResponse>> GetProjectTokenAsResponseAsync(
            string idOrName,

            global::Vercel.GetProjectTokenRequest request,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate a project OIDC token<br/>
        /// Generates an OIDC token for the project and returns it.
        /// </summary>
        /// <param name="idOrName">
        /// The project ID or name<br/>
        /// Example: my-project, &lt;prj_id&gt;
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="source">
        /// The source that is calling the endpoint.<br/>
        /// Example: vercel-cli:pull
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.GetProjectTokenResponse> GetProjectTokenAsync(
            string idOrName,
            string? teamId = default,
            string? slug = default,
            string? source = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}