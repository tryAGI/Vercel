#nullable enable

namespace Vercel
{
    public partial interface IProjectMembersClient
    {
        /// <summary>
        /// Remove a Project Member<br/>
        /// Remove a member from a specific project
        /// </summary>
        /// <param name="idOrName">
        /// The ID or name of the Project.<br/>
        /// Example: prj_pavWOn1iLObbXLRiwVvzmPrTWyTf
        /// </param>
        /// <param name="uid">
        /// The user ID of the member.<br/>
        /// Example: ndlgr43fadlPyCtREAqxxdyFK
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
        global::System.Threading.Tasks.Task<global::Vercel.RemoveProjectMemberResponse> RemoveProjectMemberAsync(
            string idOrName,
            string uid,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}