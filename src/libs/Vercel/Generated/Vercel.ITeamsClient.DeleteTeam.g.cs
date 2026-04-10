#nullable enable

namespace Vercel
{
    public partial interface ITeamsClient
    {
        /// <summary>
        /// Delete a Team<br/>
        /// Delete a team under your account. You need to send a `DELETE` request with the desired team `id`. An optional array of reasons for deletion may also be sent.
        /// </summary>
        /// <param name="newDefaultTeamId">
        /// Id of the team to be set as the new default team<br/>
        /// Example: team_LLHUOMOoDlqOp8wPE4kFo9pE
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
        global::System.Threading.Tasks.Task<global::Vercel.DeleteTeamResponse> DeleteTeamAsync(
            string teamId,

            global::Vercel.DeleteTeamRequest request,
            string? newDefaultTeamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a Team<br/>
        /// Delete a team under your account. You need to send a `DELETE` request with the desired team `id`. An optional array of reasons for deletion may also be sent.
        /// </summary>
        /// <param name="newDefaultTeamId">
        /// Id of the team to be set as the new default team<br/>
        /// Example: team_LLHUOMOoDlqOp8wPE4kFo9pE
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="reasons">
        /// Optional array of objects that describe the reason why the team is being deleted.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.DeleteTeamResponse> DeleteTeamAsync(
            string teamId,
            string? newDefaultTeamId = default,
            string? slug = default,
            global::System.Collections.Generic.IList<global::Vercel.DeleteTeamRequestReason>? reasons = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}