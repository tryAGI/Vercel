#nullable enable

namespace Vercel
{
    public partial interface ITeamsClient
    {
        /// <summary>
        /// Invite a user<br/>
        /// Invite a user to join the team specified in the URL. The authenticated user needs to be an `OWNER` in order to successfully invoke this endpoint. The user to be invited must be specified by email.
        /// </summary>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.InvitedTeamMember> InviteUserToTeamAsync(
            string teamId,

            global::System.Collections.Generic.IList<global::Vercel.InviteUserToTeamRequestItem> request,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}