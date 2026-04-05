#nullable enable

namespace Vercel
{
    public partial interface IBulkRedirectsClient
    {
        /// <summary>
        /// Delete project-level redirects.<br/>
        /// Deletes the provided redirects from the latest version of the projects' bulk redirects. Stages a new change with the new redirects and returns the alias for the new version in the response.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.OneOf<global::Vercel.DeleteRedirectsResponseVariant1, global::Vercel.DeleteRedirectsResponseVariant2, global::Vercel.DeleteRedirectsResponseVariant3>> DeleteRedirectsAsync(
            string projectId,

            global::Vercel.DeleteRedirectsRequest request,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete project-level redirects.<br/>
        /// Deletes the provided redirects from the latest version of the projects' bulk redirects. Stages a new change with the new redirects and returns the alias for the new version in the response.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="name"></param>
        /// <param name="redirects">
        /// The redirects to delete. The source of the redirect is used to match the redirect to delete.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.OneOf<global::Vercel.DeleteRedirectsResponseVariant1, global::Vercel.DeleteRedirectsResponseVariant2, global::Vercel.DeleteRedirectsResponseVariant3>> DeleteRedirectsAsync(
            string projectId,
            global::System.Collections.Generic.IList<string> redirects,
            string? teamId = default,
            string? slug = default,
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}