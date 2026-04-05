#nullable enable

namespace Vercel
{
    public partial interface IMicrofrontendsClient
    {
        /// <summary>
        /// Get microfrontends config for a deployment<br/>
        /// Get the microfrontends config for a deployment.
        /// </summary>
        /// <param name="deploymentId">
        /// The unique deployment identifier
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.GetMicrofrontendsConfigResponse> GetMicrofrontendsConfigAsync(
            string deploymentId,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}