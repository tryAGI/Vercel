#nullable enable

namespace Vercel
{
    public partial interface INetworkingClient
    {
        /// <summary>
        /// Create a PrivateLink endpoint<br/>
        /// Creates a PrivateLink endpoint for a project.
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
        global::System.Threading.Tasks.Task<global::Vercel.PrivateLinkEndpoint> CreatePrivateLinkEndpointAsync(

            global::Vercel.CreatePrivateLinkEndpointRequest request,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a PrivateLink endpoint<br/>
        /// Creates a PrivateLink endpoint for a project.
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
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.PrivateLinkEndpoint>> CreatePrivateLinkEndpointAsResponseAsync(

            global::Vercel.CreatePrivateLinkEndpointRequest request,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a PrivateLink endpoint<br/>
        /// Creates a PrivateLink endpoint for a project.
        /// </summary>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="projectId">
        /// The project ID to create the PrivateLink endpoint for.<br/>
        /// Example: prj_a1b2c3d4e5f6g7h8
        /// </param>
        /// <param name="name">
        /// The name of the PrivateLink endpoint, used as its label in the Vercel dashboard.<br/>
        /// Example: payments-db
        /// </param>
        /// <param name="vercelRegion">
        /// The Vercel region to provision the endpoint in. Advanced Networking must be enabled for the project in that region. The endpoint service itself may live in another AWS region.<br/>
        /// Example: iad1
        /// </param>
        /// <param name="awsServiceName">
        /// The name of the AWS VPC endpoint service to connect to. Its AWS region is read from the name; when that region differs from the one behind `vercelRegion`, the service must allow cross-region access.<br/>
        /// Example: com.amazonaws.vpce.us-east-1.vpce-svc-0123456789abcdef0
        /// </param>
        /// <param name="enablePrivateDns">
        /// Whether to resolve the endpoint service through its private DNS names, which are then returned in `privateDnsNames`. Defaults to `false`, in which case the endpoint is reachable through the DNS names in `awsDnsEntries`.<br/>
        /// Example: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.PrivateLinkEndpoint> CreatePrivateLinkEndpointAsync(
            string projectId,
            string name,
            string vercelRegion,
            string awsServiceName,
            string? teamId = default,
            string? slug = default,
            bool? enablePrivateDns = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}