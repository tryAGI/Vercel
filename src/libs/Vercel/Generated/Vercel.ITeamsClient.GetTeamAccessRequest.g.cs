#nullable enable

namespace Vercel
{
    public partial interface ITeamsClient
    {
        /// <summary>
        /// Get access request status<br/>
        /// Check the status of a join request. It'll respond with a 404 if the request has been declined. If no `userId` path segment was provided, this endpoint will instead return the status of the authenticated user.
        /// </summary>
        /// <param name="userId">
        /// The unique user identifier
        /// </param>
        /// <param name="teamId">
        /// The unique team identifier<br/>
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.GetTeamAccessRequestResponse> GetTeamAccessRequestAsync(
            string userId,
            string teamId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}