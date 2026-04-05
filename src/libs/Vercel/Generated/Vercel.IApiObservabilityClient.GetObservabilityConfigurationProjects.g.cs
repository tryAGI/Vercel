#nullable enable

namespace Vercel
{
    public partial interface IApiObservabilityClient
    {
        /// <summary>
        /// Lists disabled Observability Plus projects<br/>
        /// Lists the projects that are currently configured as disabled for Observability Plus on a team.
        /// </summary>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.GetObservabilityConfigurationProjectsResponse> GetObservabilityConfigurationProjectsAsync(
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}