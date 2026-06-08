#nullable enable

namespace Vercel
{
    public partial interface IConnectClient
    {
        /// <summary>
        /// Get a connector access token<br/>
        /// Get an access token for a connector identified by the path parameter and scoped to the requester.
        /// </summary>
        /// <param name="connector"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.GetConnectorTokenResponse> GetConnectorTokenAsync(
            string connector,

            global::Vercel.GetConnectorTokenRequest request,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a connector access token<br/>
        /// Get an access token for a connector identified by the path parameter and scoped to the requester.
        /// </summary>
        /// <param name="connector"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.GetConnectorTokenResponse>> GetConnectorTokenAsResponseAsync(
            string connector,

            global::Vercel.GetConnectorTokenRequest request,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a connector access token<br/>
        /// Get an access token for a connector identified by the path parameter and scoped to the requester.
        /// </summary>
        /// <param name="connector"></param>
        /// <param name="subject"></param>
        /// <param name="installationId"></param>
        /// <param name="audience"></param>
        /// <param name="scopes"></param>
        /// <param name="resources"></param>
        /// <param name="authorizationDetails"></param>
        /// <param name="validityBufferMs"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.GetConnectorTokenResponse> GetConnectorTokenAsync(
            string connector,
            global::Vercel.GetConnectorTokenRequestSubject? subject = default,
            string? installationId = default,
            global::System.Collections.Generic.IList<string>? audience = default,
            global::System.Collections.Generic.IList<string>? scopes = default,
            global::System.Collections.Generic.IList<string>? resources = default,
            global::System.Collections.Generic.IList<global::Vercel.GetConnectorTokenRequestAuthorizationDetail>? authorizationDetails = default,
            double? validityBufferMs = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}