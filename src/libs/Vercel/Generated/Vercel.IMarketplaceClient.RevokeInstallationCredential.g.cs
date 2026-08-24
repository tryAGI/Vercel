#nullable enable

namespace Vercel
{
    public partial interface IMarketplaceClient
    {
        /// <summary>
        /// Revoke Installation Credential<br/>
        /// Retires a superseded installation credential, so a partner can complete a rotation it started with `POST /credentials/rotate` — the leaked credential stops working without the customer having to reinstall. Authenticated by a live installation credential plus the integration's client secret. The credential to retire is named in the body rather than being the one that authenticates, so the ordinary flow is: rotate, store the replacement, then authenticate with the replacement and revoke the old one. Refuses to retire an installation's last live credential. Rotation exists so remediation is not customer-visible; revoking the only credential would undo that and leave the install needing a reinstall.
        /// </summary>
        /// <param name="integrationConfigurationId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.RevokeInstallationCredentialResponse> RevokeInstallationCredentialAsync(
            string integrationConfigurationId,

            global::Vercel.RevokeInstallationCredentialRequest request,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Revoke Installation Credential<br/>
        /// Retires a superseded installation credential, so a partner can complete a rotation it started with `POST /credentials/rotate` — the leaked credential stops working without the customer having to reinstall. Authenticated by a live installation credential plus the integration's client secret. The credential to retire is named in the body rather than being the one that authenticates, so the ordinary flow is: rotate, store the replacement, then authenticate with the replacement and revoke the old one. Refuses to retire an installation's last live credential. Rotation exists so remediation is not customer-visible; revoking the only credential would undo that and leave the install needing a reinstall.
        /// </summary>
        /// <param name="integrationConfigurationId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.RevokeInstallationCredentialResponse>> RevokeInstallationCredentialAsResponseAsync(
            string integrationConfigurationId,

            global::Vercel.RevokeInstallationCredentialRequest request,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Revoke Installation Credential<br/>
        /// Retires a superseded installation credential, so a partner can complete a rotation it started with `POST /credentials/rotate` — the leaked credential stops working without the customer having to reinstall. Authenticated by a live installation credential plus the integration's client secret. The credential to retire is named in the body rather than being the one that authenticates, so the ordinary flow is: rotate, store the replacement, then authenticate with the replacement and revoke the old one. Refuses to retire an installation's last live credential. Rotation exists so remediation is not customer-visible; revoking the only credential would undo that and leave the install needing a reinstall.
        /// </summary>
        /// <param name="integrationConfigurationId"></param>
        /// <param name="token"></param>
        /// <param name="clientSecret"></param>
        /// <param name="clientId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.RevokeInstallationCredentialResponse> RevokeInstallationCredentialAsync(
            string integrationConfigurationId,
            string token,
            string clientSecret,
            string? clientId = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}