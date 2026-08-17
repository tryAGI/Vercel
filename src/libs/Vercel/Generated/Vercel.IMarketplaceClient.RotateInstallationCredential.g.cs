#nullable enable

namespace Vercel
{
    public partial interface IMarketplaceClient
    {
        /// <summary>
        /// Rotate Installation Credential<br/>
        /// Issues a replacement access token for an installation, so a partner can rotate a credential it believes is compromised without the customer having to reinstall. Authenticated by the credential being replaced plus the integration's client secret: a leaked access token on its own cannot rotate itself, which would otherwise let an attacker take over the installation and lock the partner out. The previous credential intentionally stays valid so in-flight requests keep working. Retiring it is a separate, explicit operation — a partner is never left mid-rotation without a working credential.
        /// </summary>
        /// <param name="integrationConfigurationId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.RotateInstallationCredentialResponse> RotateInstallationCredentialAsync(
            string integrationConfigurationId,

            global::Vercel.RotateInstallationCredentialRequest request,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Rotate Installation Credential<br/>
        /// Issues a replacement access token for an installation, so a partner can rotate a credential it believes is compromised without the customer having to reinstall. Authenticated by the credential being replaced plus the integration's client secret: a leaked access token on its own cannot rotate itself, which would otherwise let an attacker take over the installation and lock the partner out. The previous credential intentionally stays valid so in-flight requests keep working. Retiring it is a separate, explicit operation — a partner is never left mid-rotation without a working credential.
        /// </summary>
        /// <param name="integrationConfigurationId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.RotateInstallationCredentialResponse>> RotateInstallationCredentialAsResponseAsync(
            string integrationConfigurationId,

            global::Vercel.RotateInstallationCredentialRequest request,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Rotate Installation Credential<br/>
        /// Issues a replacement access token for an installation, so a partner can rotate a credential it believes is compromised without the customer having to reinstall. Authenticated by the credential being replaced plus the integration's client secret: a leaked access token on its own cannot rotate itself, which would otherwise let an attacker take over the installation and lock the partner out. The previous credential intentionally stays valid so in-flight requests keep working. Retiring it is a separate, explicit operation — a partner is never left mid-rotation without a working credential.
        /// </summary>
        /// <param name="integrationConfigurationId"></param>
        /// <param name="clientSecret"></param>
        /// <param name="clientId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.RotateInstallationCredentialResponse> RotateInstallationCredentialAsync(
            string integrationConfigurationId,
            string clientSecret,
            string? clientId = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}