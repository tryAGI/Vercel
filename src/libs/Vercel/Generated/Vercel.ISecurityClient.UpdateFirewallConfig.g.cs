#nullable enable

namespace Vercel
{
    public partial interface ISecurityClient
    {
        /// <summary>
        /// Update Firewall Configuration<br/>
        /// Process updates to modify the existing firewall config for a project
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
        global::System.Threading.Tasks.Task<string> UpdateFirewallConfigAsync(
            string projectId,

            global::Vercel.OneOf<global::Vercel.UpdateFirewallConfigRequestVariant1, global::Vercel.UpdateFirewallConfigRequestVariant2, global::Vercel.UpdateFirewallConfigRequestVariant3, global::Vercel.UpdateFirewallConfigRequestVariant4, global::Vercel.UpdateFirewallConfigRequestVariant5, global::Vercel.UpdateFirewallConfigRequestVariant6, global::Vercel.UpdateFirewallConfigRequestVariant7, global::Vercel.UpdateFirewallConfigRequestVariant8, global::Vercel.UpdateFirewallConfigRequestVariant9, global::Vercel.UpdateFirewallConfigRequestVariant10, global::Vercel.UpdateFirewallConfigRequestVariant11, global::Vercel.UpdateFirewallConfigRequestVariant12, global::Vercel.UpdateFirewallConfigRequestVariant13, global::Vercel.UpdateFirewallConfigRequestVariant14> request,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Firewall Configuration<br/>
        /// Process updates to modify the existing firewall config for a project
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateFirewallConfigAsync(
            string projectId,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}