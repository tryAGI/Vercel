#nullable enable

namespace Vercel
{
    public partial interface IDrainsClient
    {
        /// <summary>
        /// Find a Drain by id<br/>
        /// Get the information for a specific Drain by passing the drain id in the URL.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="includeDeliveryStats">
        /// Include `deliveryStats` with the delivery health of the drain over the last 24 hours.<br/>
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
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKShared0695a89a4e02b217> GetDrainAsync(
            string id,
            bool? includeDeliveryStats = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Find a Drain by id<br/>
        /// Get the information for a specific Drain by passing the drain id in the URL.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="includeDeliveryStats">
        /// Include `deliveryStats` with the delivery health of the drain over the last 24 hours.<br/>
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
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.AutoSDKShared0695a89a4e02b217>> GetDrainAsResponseAsync(
            string id,
            bool? includeDeliveryStats = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}