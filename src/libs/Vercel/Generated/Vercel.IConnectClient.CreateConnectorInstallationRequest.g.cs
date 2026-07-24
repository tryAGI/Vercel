#nullable enable

namespace Vercel
{
    public partial interface IConnectClient
    {
        /// <summary>
        /// Create a Connect installation request<br/>
        /// Create an installation request for a connector and return the URL and verifier details needed to complete the flow.
        /// </summary>
        /// <param name="connector"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.CreateConnectorInstallationRequestResponse> CreateConnectorInstallationRequestAsync(
            string connector,

            global::Vercel.CreateConnectorInstallationRequestRequest request,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Connect installation request<br/>
        /// Create an installation request for a connector and return the URL and verifier details needed to complete the flow.
        /// </summary>
        /// <param name="connector"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.CreateConnectorInstallationRequestResponse>> CreateConnectorInstallationRequestAsResponseAsync(
            string connector,

            global::Vercel.CreateConnectorInstallationRequestRequest request,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Connect installation request<br/>
        /// Create an installation request for a connector and return the URL and verifier details needed to complete the flow.
        /// </summary>
        /// <param name="connector"></param>
        /// <param name="installationId"></param>
        /// <param name="audience"></param>
        /// <param name="scopes"></param>
        /// <param name="resources"></param>
        /// <param name="authorizationDetails"></param>
        /// <param name="validityBufferMs"></param>
        /// <param name="returnUrl"></param>
        /// <param name="webhook"></param>
        /// <param name="tenantId"></param>
        /// <param name="deviceCode"></param>
        /// <param name="expiresInMs"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.CreateConnectorInstallationRequestResponse> CreateConnectorInstallationRequestAsync(
            string connector,
            string? installationId = default,
            global::System.Collections.Generic.IList<string>? audience = default,
            global::System.Collections.Generic.IList<string>? scopes = default,
            global::System.Collections.Generic.IList<string>? resources = default,
            global::System.Collections.Generic.IList<global::Vercel.CreateConnectorInstallationRequestRequestAuthorizationDetail>? authorizationDetails = default,
            double? validityBufferMs = default,
            string? returnUrl = default,
            string? webhook = default,
            string? tenantId = default,
            bool? deviceCode = default,
            double? expiresInMs = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}