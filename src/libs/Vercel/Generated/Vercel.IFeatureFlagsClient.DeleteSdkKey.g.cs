#nullable enable

namespace Vercel
{
    public partial interface IFeatureFlagsClient
    {
        /// <summary>
        /// Delete an SDK key<br/>
        /// Deletes an SDK key.
        /// </summary>
        /// <param name="projectIdOrName">
        /// The project id or name
        /// </param>
        /// <param name="hashKey">
        /// The SDK key hash key to delete
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteSdkKeyAsync(
            string projectIdOrName,
            string hashKey,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}