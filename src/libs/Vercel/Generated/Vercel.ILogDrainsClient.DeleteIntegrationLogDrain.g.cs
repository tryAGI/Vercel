#nullable enable

namespace Vercel
{
    public partial interface ILogDrainsClient
    {
        /// <summary>
        /// Deletes the Integration log drain with the provided `id` (deprecated)<br/>
        /// Deletes the Integration log drain with the provided `id`. When using an OAuth2 Token, the log drain can be deleted only if the integration owns it.
        /// </summary>
        /// <param name="id">
        /// ID of the log drain to be deleted
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteIntegrationLogDrainAsync(
            string id,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}