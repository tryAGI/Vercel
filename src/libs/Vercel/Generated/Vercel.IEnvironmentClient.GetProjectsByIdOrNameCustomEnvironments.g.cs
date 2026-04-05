#nullable enable

namespace Vercel
{
    public partial interface IEnvironmentClient
    {
        /// <summary>
        /// Retrieve custom environments<br/>
        /// Retrieve custom environments for the project. Must not be named 'Production' or 'Preview'.
        /// </summary>
        /// <param name="idOrName">
        /// The unique project identifier or the project name
        /// </param>
        /// <param name="gitBranch">
        /// Fetch custom environments for a specific git branch
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.GetProjectsByIdOrNameCustomEnvironmentsResponse> GetProjectsByIdOrNameCustomEnvironmentsAsync(
            string idOrName,
            string? gitBranch = default,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}