#nullable enable

namespace Vercel
{
    public partial interface ITeamsClient
    {
        /// <summary>
        /// Delete a Team invite code<br/>
        /// Delete an active Team invite code.
        /// </summary>
        /// <param name="inviteId">
        /// The Team invite code ID.<br/>
        /// Example: 2wn2hudbr4chb1ecywo9dvzo7g9sscs6mzcz8htdde0txyom4l
        /// </param>
        /// <param name="teamId">
        /// The Team identifier to perform the request on behalf of.<br/>
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.DeleteTeamInviteCodeResponse> DeleteTeamInviteCodeAsync(
            string inviteId,
            string teamId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}