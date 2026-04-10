#nullable enable

namespace Vercel
{
    public partial interface ISecurityClient
    {
        /// <summary>
        /// Create System Bypass Rule<br/>
        /// Create new system bypass rules
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.OneOf<global::Vercel.AddBypassIpResponseVariant1, global::Vercel.AddBypassIpResponseVariant2>> AddBypassIpAsync(
            string projectId,

            global::Vercel.AddBypassIpRequest request,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create System Bypass Rule<br/>
        /// Create new system bypass rules
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="domain"></param>
        /// <param name="projectScope">
        /// If the specified bypass will apply to all domains for a project.
        /// </param>
        /// <param name="sourceIp"></param>
        /// <param name="allSources"></param>
        /// <param name="ttl">
        /// Time to live in milliseconds
        /// </param>
        /// <param name="note"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.OneOf<global::Vercel.AddBypassIpResponseVariant1, global::Vercel.AddBypassIpResponseVariant2>> AddBypassIpAsync(
            string projectId,
            string? teamId = default,
            string? slug = default,
            string? domain = default,
            bool? projectScope = default,
            string? sourceIp = default,
            bool? allSources = default,
            double? ttl = default,
            string? note = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}