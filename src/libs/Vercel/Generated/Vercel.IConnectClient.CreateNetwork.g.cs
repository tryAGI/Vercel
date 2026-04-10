#nullable enable

namespace Vercel
{
    public partial interface IConnectClient
    {
        /// <summary>
        /// Create a Secure Compute network<br/>
        /// Allows to create a Secure Compute network.
        /// </summary>
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
        global::System.Threading.Tasks.Task<global::Vercel.Network> CreateNetworkAsync(

            global::Vercel.CreateNetworkRequest request,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Secure Compute network<br/>
        /// Allows to create a Secure Compute network.
        /// </summary>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="awsAvailabilityZoneIds"></param>
        /// <param name="cidr">
        /// The CIDR block of the network<br/>
        /// Example: 192.168.0.0/16
        /// </param>
        /// <param name="name">
        /// The name of the network
        /// </param>
        /// <param name="region">
        /// The region where the network will be created<br/>
        /// Example: iad1
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.Network> CreateNetworkAsync(
            string cidr,
            string name,
            string region,
            string? teamId = default,
            string? slug = default,
            global::System.Collections.Generic.IList<string>? awsAvailabilityZoneIds = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}