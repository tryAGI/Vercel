#nullable enable

namespace Vercel
{
    public partial interface IChecksV2Client
    {
        /// <summary>
        /// List runs for a check<br/>
        /// List all runs associated with a given check.
        /// </summary>
        /// <param name="projectIdOrName"></param>
        /// <param name="checkId">
        /// The ID of the resource that will be updated.<br/>
        /// Example: ckr_89ha9sdhh9a9
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.ListCheckRunsResponse> ListCheckRunsAsync(
            string projectIdOrName,
            string checkId,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}