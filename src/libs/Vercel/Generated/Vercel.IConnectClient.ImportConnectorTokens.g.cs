#nullable enable

namespace Vercel
{
    public partial interface IConnectClient
    {
        /// <summary>
        /// Import Connect tokens<br/>
        /// Import access and refresh tokens for a connector identified by the path parameter.
        /// </summary>
        /// <param name="connector"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.ImportConnectorTokensResponse> ImportConnectorTokensAsync(
            string connector,

            global::Vercel.ImportConnectorTokensRequest request,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Import Connect tokens<br/>
        /// Import access and refresh tokens for a connector identified by the path parameter.
        /// </summary>
        /// <param name="connector"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.ImportConnectorTokensResponse>> ImportConnectorTokensAsResponseAsync(
            string connector,

            global::Vercel.ImportConnectorTokensRequest request,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Import Connect tokens<br/>
        /// Import access and refresh tokens for a connector identified by the path parameter.
        /// </summary>
        /// <param name="connector"></param>
        /// <param name="tokens"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.ImportConnectorTokensResponse> ImportConnectorTokensAsync(
            string connector,
            global::System.Collections.Generic.IList<global::Vercel.ImportConnectorTokensRequestToken> tokens,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}