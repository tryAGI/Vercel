#nullable enable

namespace Vercel
{
    public partial interface IProjectMembersClient
    {
        /// <summary>
        /// Adds a new member to a project.<br/>
        /// Adds a new member to the project.
        /// </summary>
        /// <param name="idOrName">
        /// The ID or name of the Project.<br/>
        /// Example: prj_pavWOn1iLObbXLRiwVvzmPrTWyTf
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
        global::System.Threading.Tasks.Task<global::Vercel.AddProjectMemberResponse> AddProjectMemberAsync(
            string idOrName,

            global::Vercel.AddProjectMemberRequest request,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Adds a new member to a project.<br/>
        /// Adds a new member to the project.
        /// </summary>
        /// <param name="idOrName">
        /// The ID or name of the Project.<br/>
        /// Example: prj_pavWOn1iLObbXLRiwVvzmPrTWyTf
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="uid">
        /// The ID of the team member that should be added to this project.<br/>
        /// Example: ndlgr43fadlPyCtREAqxxdyFK
        /// </param>
        /// <param name="username">
        /// The username of the team member that should be added to this project.<br/>
        /// Example: example
        /// </param>
        /// <param name="email">
        /// The email of the team member that should be added to this project.<br/>
        /// Example: entity@example.com
        /// </param>
        /// <param name="role">
        /// The project role of the member that will be added.<br/>
        /// Example: ADMIN
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.AddProjectMemberResponse> AddProjectMemberAsync(
            string idOrName,
            global::Vercel.AddProjectMemberRequestRole role,
            string? teamId = default,
            string? slug = default,
            string? uid = default,
            string? username = default,
            string? email = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}