#nullable enable

namespace Vercel
{
    public partial interface ITeamsClient
    {
        /// <summary>
        /// Request access to a team<br/>
        /// Request access to a team as a member. An owner has to approve the request. Only 10 users can request access to a team at the same time.
        /// </summary>
        /// <param name="teamId">
        /// The unique team identifier<br/>
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.RequestAccessToTeamResponse> RequestAccessToTeamAsync(
            string teamId,

            global::Vercel.RequestAccessToTeamRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Request access to a team<br/>
        /// Request access to a team as a member. An owner has to approve the request. Only 10 users can request access to a team at the same time.
        /// </summary>
        /// <param name="teamId">
        /// The unique team identifier<br/>
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="joinedFrom"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.RequestAccessToTeamResponse> RequestAccessToTeamAsync(
            string teamId,
            global::Vercel.RequestAccessToTeamRequestJoinedFrom joinedFrom,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}