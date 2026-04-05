#nullable enable

namespace Vercel
{
    public partial interface IChecksV2Client
    {
        /// <summary>
        /// Create a check<br/>
        /// Creates a new check for a project.
        /// </summary>
        /// <param name="projectIdOrName"></param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.CreateProjectCheckResponse> CreateProjectCheckAsync(
            string projectIdOrName,

            global::Vercel.CreateProjectCheckRequest request,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a check<br/>
        /// Creates a new check for a project.
        /// </summary>
        /// <param name="projectIdOrName"></param>
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
        /// <param name="source"></param>
        /// <param name="timeout">
        /// Default Value: 300
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.CreateProjectCheckResponse> CreateProjectCheckAsync(
            string projectIdOrName,
            string name,
            string? teamId = default,
            string? slug = default,
            bool? isRerequestable = default,
            global::Vercel.CreateProjectCheckRequestRequires requires = global::Vercel.CreateProjectCheckRequestRequires.DeploymentUrl,
            global::System.Collections.Generic.IList<string>? targets = default,
            global::Vercel.CreateProjectCheckRequestBlocks? blocks = default,
            global::Vercel.OneOf<global::Vercel.CreateProjectCheckRequestSourceVariant1, global::Vercel.CreateProjectCheckRequestSourceVariant2, global::Vercel.CreateProjectCheckRequestSourceVariant3>? source = default,
            double? timeout = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}