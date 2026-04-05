#nullable enable

namespace Vercel
{
    public partial interface IBulkRedirectsClient
    {
        /// <summary>
        /// Stages new redirects for a project.<br/>
        /// Stages new redirects for a project and returns the new version.
        /// </summary>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.StageRedirectsResponse> StageRedirectsAsync(

            global::Vercel.StageRedirectsRequest request,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Stages new redirects for a project.<br/>
        /// Stages new redirects for a project and returns the new version.
        /// </summary>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="requestTeamId"></param>
        /// <param name="overwrite"></param>
        /// <param name="name"></param>
        /// <param name="redirects">
        /// Default Value: []
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.StageRedirectsResponse> StageRedirectsAsync(
            string projectId,
            string requestTeamId,
            string? teamId = default,
            string? slug = default,
            bool? overwrite = default,
            string? name = default,
            global::System.Collections.Generic.IList<global::Vercel.StageRedirectsRequestRedirect>? redirects = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}