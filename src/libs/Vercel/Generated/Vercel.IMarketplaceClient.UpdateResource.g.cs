#nullable enable

namespace Vercel
{
    public partial interface IMarketplaceClient
    {
        /// <summary>
        /// Update Resource<br/>
        /// This endpoint updates an existing resource in the installation. All parameters are optional, allowing partial updates.
        /// </summary>
        /// <param name="integrationConfigurationId"></param>
        /// <param name="resourceId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.UpdateResourceResponse> UpdateResourceAsync(
            string integrationConfigurationId,
            string resourceId,

            global::Vercel.UpdateResourceRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Resource<br/>
        /// This endpoint updates an existing resource in the installation. All parameters are optional, allowing partial updates.
        /// </summary>
        /// <param name="integrationConfigurationId"></param>
        /// <param name="resourceId"></param>
        /// <param name="ownership"></param>
        /// <param name="name"></param>
        /// <param name="status"></param>
        /// <param name="metadata"></param>
        /// <param name="billingPlan"></param>
        /// <param name="notification"></param>
        /// <param name="extras"></param>
        /// <param name="secrets"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.UpdateResourceResponse> UpdateResourceAsync(
            string integrationConfigurationId,
            string resourceId,
            global::Vercel.UpdateResourceRequestOwnership? ownership = default,
            string? name = default,
            global::Vercel.UpdateResourceRequestStatus? status = default,
            object? metadata = default,
            global::Vercel.UpdateResourceRequestBillingPlan? billingPlan = default,
            global::Vercel.OneOf<global::Vercel.UpdateResourceRequestNotification, string>? notification = default,
            object? extras = default,
            global::Vercel.OneOf<global::System.Collections.Generic.IList<global::Vercel.UpdateResourceRequestSecret>, global::Vercel.UpdateResourceRequestSecrets>? secrets = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}