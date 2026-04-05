#nullable enable

namespace Vercel
{
    public partial interface ITeamsClient
    {
        /// <summary>
        /// Update a Team Member<br/>
        /// Update the membership of a Team Member on the Team specified by `teamId`, such as changing the _role_ of the member, or confirming a request to join the Team for an unconfirmed member. The authenticated user must be an `OWNER` of the Team.
        /// </summary>
        /// <param name="uid">
        /// The ID of the member.<br/>
        /// Example: ndfasllgPyCtREAqxxdyFKb
        /// </param>
        /// <param name="teamId">
        /// The unique team identifier<br/>
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.UpdateTeamMemberResponse> UpdateTeamMemberAsync(
            string uid,
            string teamId,

            global::Vercel.UpdateTeamMemberRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a Team Member<br/>
        /// Update the membership of a Team Member on the Team specified by `teamId`, such as changing the _role_ of the member, or confirming a request to join the Team for an unconfirmed member. The authenticated user must be an `OWNER` of the Team.
        /// </summary>
        /// <param name="uid">
        /// The ID of the member.<br/>
        /// Example: ndfasllgPyCtREAqxxdyFKb
        /// </param>
        /// <param name="teamId">
        /// The unique team identifier<br/>
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="confirmed">
        /// Accept a user who requested access to the team.<br/>
        /// Example: true
        /// </param>
        /// <param name="role">
        /// The role in the team of the member.<br/>
        /// Default Value: MEMBER<br/>
        /// Example: VIEWER
        /// </param>
        /// <param name="projects"></param>
        /// <param name="joinedFrom"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.UpdateTeamMemberResponse> UpdateTeamMemberAsync(
            string uid,
            string teamId,
            bool? confirmed = default,
            string? role = default,
            global::System.Collections.Generic.IList<global::Vercel.UpdateTeamMemberRequestProject>? projects = default,
            global::Vercel.UpdateTeamMemberRequestJoinedFrom? joinedFrom = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}