#nullable enable

namespace Vercel
{
    public partial interface IConnectClient
    {
        /// <summary>
        /// List Secure Compute networks<br/>
        /// Allows to list Secure Compute networks.
        /// </summary>
        /// <param name="includeHostedZones">
        /// Whether to include Hosted Zones in the response<br/>
        /// Default Value: true
        /// </param>
        /// <param name="includePeeringConnections">
        /// Whether to include VPC Peering connections in the response<br/>
        /// Default Value: true
        /// </param>
        /// <param name="includeProjects">
        /// Whether to include projects in the response<br/>
        /// Default Value: true
        /// </param>
        /// <param name="search">
        /// The query to use as a filter for returned networks
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Vercel.Network>> ListNetworksAsync(
            bool? includeHostedZones = default,
            bool? includePeeringConnections = default,
            bool? includeProjects = default,
            string? search = default,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}