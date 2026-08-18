#nullable enable

namespace Vercel
{
    public partial interface IKmsClient
    {
        /// <summary>
        /// Sign a token<br/>
        /// Sign a JWT with a KMS issuer's active signing key. Authenticate the request with a Vercel OIDC token in the `Authorization: Bearer` header; the issuer's policies decide which workloads are allowed to sign.
        /// </summary>
        /// <param name="issuerId">
        /// The ID of the issuer.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.SignKmsTokenResponse> SignKmsTokenAsync(
            string issuerId,

            global::Vercel.SignKmsTokenRequest request,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Sign a token<br/>
        /// Sign a JWT with a KMS issuer's active signing key. Authenticate the request with a Vercel OIDC token in the `Authorization: Bearer` header; the issuer's policies decide which workloads are allowed to sign.
        /// </summary>
        /// <param name="issuerId">
        /// The ID of the issuer.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.SignKmsTokenResponse>> SignKmsTokenAsResponseAsync(
            string issuerId,

            global::Vercel.SignKmsTokenRequest request,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Sign a token<br/>
        /// Sign a JWT with a KMS issuer's active signing key. Authenticate the request with a Vercel OIDC token in the `Authorization: Bearer` header; the issuer's policies decide which workloads are allowed to sign.
        /// </summary>
        /// <param name="issuerId">
        /// The ID of the issuer.
        /// </param>
        /// <param name="claims">
        /// The claims to include in the token.
        /// </param>
        /// <param name="headers">
        /// Additional headers to include in the token.
        /// </param>
        /// <param name="ttl">
        /// The time-to-live for the token, in seconds.<br/>
        /// Default Value: 300
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.SignKmsTokenResponse> SignKmsTokenAsync(
            string issuerId,
            object? claims = default,
            object? headers = default,
            double? ttl = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}