#nullable enable

namespace Vercel
{
    public partial interface ILogDrainsClient
    {
        /// <summary>
        /// Deletes a Configurable Log Drain (deprecated)<br/>
        /// Deletes a Configurable Log Drain. This endpoint must be called with a team AccessToken (integration OAuth2 clients are not allowed). Only log drains owned by the authenticated team can be deleted.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteConfigurableLogDrainAsync(
            string id,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}