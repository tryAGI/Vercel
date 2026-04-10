#nullable enable

namespace Vercel
{
    public partial interface IMarketplaceClient
    {
        /// <summary>
        /// Import Resource<br/>
        /// This endpoint imports (upserts) a resource to Vercel's installation. This may be needed if resources can be independently created on the partner's side and need to be synchronized to Vercel.
        /// </summary>
        /// <param name="integrationConfigurationId"></param>
        /// <param name="resourceId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.ImportResourceResponse> ImportResourceAsync(
            string integrationConfigurationId,
            string resourceId,

            global::Vercel.ImportResourceRequest request,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Import Resource<br/>
        /// This endpoint imports (upserts) a resource to Vercel's installation. This may be needed if resources can be independently created on the partner's side and need to be synchronized to Vercel.
        /// </summary>
        /// <param name="integrationConfigurationId"></param>
        /// <param name="resourceId"></param>
        /// <param name="ownership"></param>
        /// <param name="productId"></param>
        /// <param name="name"></param>
        /// <param name="status"></param>
        /// <param name="metadata"></param>
        /// <param name="billingPlan"></param>
        /// <param name="notification"></param>
        /// <param name="extras"></param>
        /// <param name="secrets"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.ImportResourceResponse> ImportResourceAsync(
            string integrationConfigurationId,
            string resourceId,
            string productId,
            string name,
            global::Vercel.ImportResourceRequestStatus status,
            global::Vercel.ImportResourceRequestOwnership? ownership = default,
            object? metadata = default,
            global::Vercel.ImportResourceRequestBillingPlan? billingPlan = default,
            global::Vercel.ImportResourceRequestNotification? notification = default,
            object? extras = default,
            global::System.Collections.Generic.IList<global::Vercel.ImportResourceRequestSecret>? secrets = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}