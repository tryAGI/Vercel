#nullable enable

namespace Vercel
{
    public partial interface IAiGatewayClient
    {
        /// <summary>
        /// Update an AI Gateway API key budget<br/>
        /// Set, change, or remove the AI Gateway budget on an API key. Creates the budget if the key does not have one.
        /// </summary>
        /// <param name="apiKeyID">
        /// The ID of the API key whose quota should be updated.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.UpdateApiKeyQuotaResponse> UpdateApiKeyQuotaAsync(
            string apiKeyID,

            global::Vercel.UpdateApiKeyQuotaRequest request,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an AI Gateway API key budget<br/>
        /// Set, change, or remove the AI Gateway budget on an API key. Creates the budget if the key does not have one.
        /// </summary>
        /// <param name="apiKeyID">
        /// The ID of the API key whose quota should be updated.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.UpdateApiKeyQuotaResponse>> UpdateApiKeyQuotaAsResponseAsync(
            string apiKeyID,

            global::Vercel.UpdateApiKeyQuotaRequest request,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an AI Gateway API key budget<br/>
        /// Set, change, or remove the AI Gateway budget on an API key. Creates the budget if the key does not have one.
        /// </summary>
        /// <param name="apiKeyID">
        /// The ID of the API key whose quota should be updated.
        /// </param>
        /// <param name="limitAmount">
        /// The quota limit amount. Required if the quota does not yet exist.
        /// </param>
        /// <param name="includeByokInQuota">
        /// Whether BYOK (Bring Your Own Key) usage counts against the quota.
        /// </param>
        /// <param name="refreshPeriod">
        /// How often the quota refreshes.
        /// </param>
        /// <param name="active">
        /// Whether the quota is currently active.
        /// </param>
        /// <param name="archived">
        /// Set to true to archive (soft-delete) the quota. The api key itself is unaffected.
        /// </param>
        /// <param name="alertThresholds">
        /// Spend percentages (a subset of [50, 75, 100]) at which to send a spend alert. Pass an empty array to disable alerts.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.UpdateApiKeyQuotaResponse> UpdateApiKeyQuotaAsync(
            string apiKeyID,
            double? limitAmount = default,
            bool? includeByokInQuota = default,
            global::Vercel.UpdateApiKeyQuotaRequestRefreshPeriod? refreshPeriod = default,
            bool? active = default,
            bool? archived = default,
            global::System.Collections.Generic.IList<double>? alertThresholds = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}