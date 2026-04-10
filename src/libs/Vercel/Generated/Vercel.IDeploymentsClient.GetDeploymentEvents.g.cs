#nullable enable

namespace Vercel
{
    public partial interface IDeploymentsClient
    {
        /// <summary>
        /// Get deployment events<br/>
        /// Get the build logs of a deployment by deployment ID and build ID. It can work as an infinite stream of logs or as a JSON endpoint depending on the input parameters.
        /// </summary>
        /// <param name="idOrUrl">
        /// The unique identifier or hostname of the deployment.<br/>
        /// Example: dpl_5WJWYSyB7BpgTj3EuwF37WMRBXBtPQ2iTMJHJBJyRfd
        /// </param>
        /// <param name="direction">
        /// Order of the returned events based on the timestamp.<br/>
        /// Default Value: forward<br/>
        /// Example: backward
        /// </param>
        /// <param name="follow">
        /// When enabled, this endpoint will return live events as they happen.<br/>
        /// Example: 1
        /// </param>
        /// <param name="limit">
        /// Maximum number of events to return. Provide `-1` to return all available logs.<br/>
        /// Example: 100
        /// </param>
        /// <param name="name">
        /// Deployment build ID.<br/>
        /// Example: bld_cotnkcr76
        /// </param>
        /// <param name="since">
        /// Timestamp for when build logs should be pulled from.<br/>
        /// Example: 1540095775941L
        /// </param>
        /// <param name="until">
        /// Timestamp for when the build logs should be pulled up until.<br/>
        /// Example: 1540106318643L
        /// </param>
        /// <param name="statusCode">
        /// HTTP status code range to filter events by.<br/>
        /// Example: 5xx
        /// </param>
        /// <param name="delimiter">
        /// Example: 1
        /// </param>
        /// <param name="builds">
        /// Example: 1
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.GetDeploymentEventsResponseItemVariant1, global::Vercel.GetDeploymentEventsResponseItemVariant2>>> GetDeploymentEventsAsync(
            string idOrUrl,
            global::Vercel.GetDeploymentEventsDirection? direction = default,
            double? follow = default,
            double? limit = default,
            string? name = default,
            double? since = default,
            double? until = default,
            global::Vercel.OneOf<double?, string>? statusCode = default,
            double? delimiter = default,
            double? builds = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}