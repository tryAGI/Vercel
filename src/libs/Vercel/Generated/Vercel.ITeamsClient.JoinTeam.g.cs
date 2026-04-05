#nullable enable

namespace Vercel
{
    public partial interface ITeamsClient
    {
        /// <summary>
        /// Join a team<br/>
        /// Join a team with a provided invite code or team ID.
        /// </summary>
        /// <param name="teamId">
        /// The unique team identifier<br/>
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.JoinTeamResponse> JoinTeamAsync(
            string teamId,

            global::Vercel.JoinTeamRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Join a team<br/>
        /// Join a team with a provided invite code or team ID.
        /// </summary>
        /// <param name="teamId">
        /// The unique team identifier<br/>
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="inviteCode">
        /// The invite code to join the team.<br/>
        /// Example: fisdh38aejkeivn34nslfore9vjtn4ls
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.JoinTeamResponse> JoinTeamAsync(
            string teamId,
            string? inviteCode = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}