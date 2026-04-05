#nullable enable

namespace Vercel
{
    public partial interface IProjectRoutesClient
    {
        /// <summary>
        /// Stage routing rules<br/>
        /// Stage routing rules for a project. Set `overwrite` to true to replace all existing rules, or omit it to merge with existing rules by ID. Returns the new staged version.
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
        global::System.Threading.Tasks.Task<global::Vercel.StageRoutesResponse> StageRoutesAsync(
            string projectId,

            global::Vercel.StageRoutesRequest request,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Stage routing rules<br/>
        /// Stage routing rules for a project. Set `overwrite` to true to replace all existing rules, or omit it to merge with existing rules by ID. Returns the new staged version.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="overwrite"></param>
        /// <param name="routes">
        /// Default Value: []
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.StageRoutesResponse> StageRoutesAsync(
            string projectId,
            string? teamId = default,
            string? slug = default,
            bool? overwrite = default,
            global::System.Collections.Generic.IList<global::Vercel.StageRoutesRequestRoute>? routes = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}