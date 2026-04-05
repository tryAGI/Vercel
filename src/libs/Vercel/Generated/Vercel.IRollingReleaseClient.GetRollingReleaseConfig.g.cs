#nullable enable

namespace Vercel
{
    public partial interface IRollingReleaseClient
    {
        /// <summary>
        /// Get rolling release configuration<br/>
        /// Get the Rolling Releases configuration for a project. The project-level config is simply a template that will be used for any future rolling release, and not the configuration for any active rolling release.
        /// </summary>
        /// <param name="idOrName">
        /// Project ID or project name (URL-encoded)
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.GetRollingReleaseConfigResponse> GetRollingReleaseConfigAsync(
            string idOrName,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}