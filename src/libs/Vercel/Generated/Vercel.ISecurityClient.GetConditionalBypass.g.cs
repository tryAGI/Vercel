#nullable enable

namespace Vercel
{
    public partial interface ISecurityClient
    {
        /// <summary>
        /// Get conditional firewall bypasses<br/>
        /// Retrieve conditional firewall bypass rules for a project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="domain"></param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.OneOf<global::Vercel.GetConditionalBypassResponseVariant1, global::Vercel.GetConditionalBypassResponseVariant2>> GetConditionalBypassAsync(
            string projectId,
            string? slug = default,
            string? domain = default,
            string? teamId = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get conditional firewall bypasses<br/>
        /// Retrieve conditional firewall bypass rules for a project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="domain"></param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.OneOf<global::Vercel.GetConditionalBypassResponseVariant1, global::Vercel.GetConditionalBypassResponseVariant2>>> GetConditionalBypassAsResponseAsync(
            string projectId,
            string? slug = default,
            string? domain = default,
            string? teamId = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}