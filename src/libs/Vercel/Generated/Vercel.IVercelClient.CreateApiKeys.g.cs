#nullable enable

namespace Vercel
{
    public partial interface IVercelClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.CreateApiKeysResponse> CreateApiKeysAsync(

            global::Vercel.CreateApiKeysRequest request,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.CreateApiKeysResponse>> CreateApiKeysAsResponseAsync(

            global::Vercel.CreateApiKeysRequest request,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="purpose">
        /// The API key's purpose, which restricts how it can be used.
        /// </param>
        /// <param name="projectId">
        /// An optional project to restrict the API key to.<br/>
        /// Example: prj_12HKQaOmR5t5Uy6vdcQsNIiZgHGB
        /// </param>
        /// <param name="name">
        /// An optional name for the API key.<br/>
        /// Example: API Key for App 123
        /// </param>
        /// <param name="expiresAt">
        /// The API key's expiration, expressed as a UNIX timestamp in milliseconds.
        /// </param>
        /// <param name="aiGatewayQuota">
        /// Optional AI Gateway quota configuration for the API key.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.CreateApiKeysResponse> CreateApiKeysAsync(
            string purpose,
            string? projectId = default,
            string? name = default,
            double? expiresAt = default,
            global::Vercel.CreateApiKeysRequestAiGatewayQuota? aiGatewayQuota = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}