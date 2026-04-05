#nullable enable

namespace Vercel
{
    public partial interface ISecurityClient
    {
        /// <summary>
        /// Read Firewall Actions by Project<br/>
        /// Retrieve firewall actions for a project
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="startTimestamp"></param>
        /// <param name="endTimestamp"></param>
        /// <param name="hosts"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.GetSecurityFirewallEventsResponse> GetSecurityFirewallEventsAsync(
            string projectId,
            double? startTimestamp = default,
            double? endTimestamp = default,
            string? hosts = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}