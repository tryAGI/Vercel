#nullable enable

namespace Vercel
{
    public partial interface ITeamsClient
    {
        /// <summary>
        /// Remove a Team Member<br/>
        /// Remove a Team Member from the Team, or dismiss a user that requested access, or leave a team.
        /// </summary>
        /// <param name="uid">
        /// The user ID of the member.<br/>
        /// Example: ndlgr43fadlPyCtREAqxxdyFK
        /// </param>
        /// <param name="newDefaultTeamId">
        /// The ID of the team to set as the new default team for the Northstar user.<br/>
        /// Example: team_nllPyCtREAqxxdyFKbbMDlxd
        /// </param>
        /// <param name="teamId">
        /// The unique team identifier<br/>
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.RemoveTeamMemberResponse> RemoveTeamMemberAsync(
            string uid,
            string teamId,
            string? newDefaultTeamId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}