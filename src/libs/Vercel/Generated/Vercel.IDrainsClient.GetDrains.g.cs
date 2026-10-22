#nullable enable

namespace Vercel
{
    public partial interface IDrainsClient
    {
        /// <summary>
        /// Retrieve a list of all Drains<br/>
        /// Allows to retrieve the list of Drains of the authenticated team.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="includeMetadata">
        /// Default Value: false
        /// </param>
        /// <param name="includeDeliveryStats">
        /// Include `deliveryStats` with the delivery health of each drain over the last 24 hours.<br/>
        /// Default Value: false
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
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKSharedcb80cddcfcfd675b> GetDrainsAsync(
            string? projectId = default,
            bool? includeMetadata = default,
            bool? includeDeliveryStats = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve a list of all Drains<br/>
        /// Allows to retrieve the list of Drains of the authenticated team.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="includeMetadata">
        /// Default Value: false
        /// </param>
        /// <param name="includeDeliveryStats">
        /// Include `deliveryStats` with the delivery health of each drain over the last 24 hours.<br/>
        /// Default Value: false
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
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.AutoSDKSharedcb80cddcfcfd675b>> GetDrainsAsResponseAsync(
            string? projectId = default,
            bool? includeMetadata = default,
            bool? includeDeliveryStats = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}