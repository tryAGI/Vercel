#nullable enable

namespace Vercel
{
    public partial interface ISecurityClient
    {
        /// <summary>
        /// Read System Bypass<br/>
        /// Retrieve the system bypass rules configured for the specified project
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="limit">
        /// Example: 10
        /// </param>
        /// <param name="sourceIp">
        /// Filter by source IP
        /// </param>
        /// <param name="domain">
        /// Filter by domain
        /// </param>
        /// <param name="projectScope">
        /// Filter by project scoped rules
        /// </param>
        /// <param name="offset">
        /// Used for pagination. Retrieves results after the provided id
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.GetBypassIpResponse> GetBypassIpAsync(
            string projectId,
            double? limit = default,
            string? sourceIp = default,
            string? domain = default,
            bool? projectScope = default,
            string? offset = default,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}