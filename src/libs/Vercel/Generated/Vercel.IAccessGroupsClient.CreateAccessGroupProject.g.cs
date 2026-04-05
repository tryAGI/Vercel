#nullable enable

namespace Vercel
{
    public partial interface IAccessGroupsClient
    {
        /// <summary>
        /// Create an access group project<br/>
        /// Allows creation of an access group project
        /// </summary>
        /// <param name="accessGroupIdOrName"></param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.CreateAccessGroupProjectResponse> CreateAccessGroupProjectAsync(
            string accessGroupIdOrName,

            global::Vercel.CreateAccessGroupProjectRequest request,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an access group project<br/>
        /// Allows creation of an access group project
        /// </summary>
        /// <param name="accessGroupIdOrName"></param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="projectId">
        /// The ID of the project.<br/>
        /// Example: prj_ndlgr43fadlPyCtREAqxxdyFK
        /// </param>
        /// <param name="role">
        /// The project role that will be added to this Access Group.<br/>
        /// Example: ADMIN
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.CreateAccessGroupProjectResponse> CreateAccessGroupProjectAsync(
            string accessGroupIdOrName,
            string projectId,
            global::Vercel.CreateAccessGroupProjectRequestRole role,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}