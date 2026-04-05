#nullable enable

namespace Vercel
{
    public partial interface ISecurityClient
    {
        /// <summary>
        /// Read Firewall Configuration<br/>
        /// Retrieve the specified firewall configuration for a project. The deployed configVersion will be `active`
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="configVersion"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.GetFirewallConfigResponse> GetFirewallConfigAsync(
            string projectId,
            string configVersion,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}