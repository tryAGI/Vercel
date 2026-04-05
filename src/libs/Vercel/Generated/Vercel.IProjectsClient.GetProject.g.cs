#nullable enable

namespace Vercel
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Find a project by id or name<br/>
        /// Get the information for a specific project by passing either the project `id` or `name` in the URL.
        /// </summary>
        /// <param name="idOrName">
        /// The unique project identifier or the project name
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.GetProjectResponse> GetProjectAsync(
            global::Vercel.OneOf<string, bool?> idOrName,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}