#nullable enable

namespace Vercel
{
    public partial interface IMarketplaceClient
    {
        /// <summary>
        /// Update Installation<br/>
        /// This endpoint updates an integration installation.
        /// </summary>
        /// <param name="integrationConfigurationId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task UpdateInstallationAsync(
            string integrationConfigurationId,

            global::Vercel.UpdateInstallationRequest request,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Installation<br/>
        /// This endpoint updates an integration installation.
        /// </summary>
        /// <param name="integrationConfigurationId"></param>
        /// <param name="status"></param>
        /// <param name="externalId"></param>
        /// <param name="billingPlan"></param>
        /// <param name="notification">
        /// A notification to display to your customer. Send `null` to clear the current notification.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task UpdateInstallationAsync(
            string integrationConfigurationId,
            global::Vercel.UpdateInstallationRequestStatus? status = default,
            string? externalId = default,
            global::Vercel.UpdateInstallationRequestBillingPlan? billingPlan = default,
            global::Vercel.OneOf<global::Vercel.UpdateInstallationRequestNotification, string>? notification = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}