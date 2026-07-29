#nullable enable

namespace Vercel
{
    public partial interface ISecurityClient
    {
        /// <summary>
        /// Returns activated WAF config<br/>
        /// Promotes a draft WAF config to an active config
        /// </summary>
        /// <param name="configVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.CreateSecurityFirewallConfigByConfigVersionActivateResponse> CreateSecurityFirewallConfigByConfigVersionActivateAsync(
            string configVersion,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Returns activated WAF config<br/>
        /// Promotes a draft WAF config to an active config
        /// </summary>
        /// <param name="configVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.CreateSecurityFirewallConfigByConfigVersionActivateResponse>> CreateSecurityFirewallConfigByConfigVersionActivateAsResponseAsync(
            string configVersion,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}