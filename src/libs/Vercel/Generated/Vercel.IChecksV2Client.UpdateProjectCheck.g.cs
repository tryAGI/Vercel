#nullable enable

namespace Vercel
{
    public partial interface IChecksV2Client
    {
        /// <summary>
        /// Update a check<br/>
        /// Update an existing check.
        /// </summary>
        /// <param name="projectIdOrName"></param>
        /// <param name="checkId"></param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.UpdateProjectCheckResponse> UpdateProjectCheckAsync(
            string projectIdOrName,
            string checkId,

            global::Vercel.UpdateProjectCheckRequest request,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a check<br/>
        /// Update an existing check.
        /// </summary>
        /// <param name="projectIdOrName"></param>
        /// <param name="checkId"></param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="name"></param>
        /// <param name="isRerequestable"></param>
        /// <param name="requires">
        /// Default Value: deployment-url
        /// </param>
        /// <param name="targets"></param>
        /// <param name="blocks">
        /// Default Value: deployment-alias
        /// </param>
        /// <param name="timeout">
        /// Default Value: 300
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.UpdateProjectCheckResponse> UpdateProjectCheckAsync(
            string projectIdOrName,
            string checkId,
            string? teamId = default,
            string? slug = default,
            string? name = default,
            bool? isRerequestable = default,
            global::Vercel.UpdateProjectCheckRequestRequires? requires = default,
            global::System.Collections.Generic.IList<string>? targets = default,
            global::Vercel.UpdateProjectCheckRequestBlocks? blocks = default,
            double? timeout = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}