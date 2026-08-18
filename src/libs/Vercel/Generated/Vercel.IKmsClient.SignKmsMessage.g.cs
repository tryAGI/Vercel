#nullable enable

namespace Vercel
{
    public partial interface IKmsClient
    {
        /// <summary>
        /// Sign a message<br/>
        /// Sign a raw message with a KMS issuer's active signing key. Authenticate the request with a Vercel OIDC token in the `Authorization: Bearer` header; the issuer's policies decide which workloads are allowed to sign.
        /// </summary>
        /// <param name="issuerId">
        /// The ID of the issuer.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.SignKmsMessageResponse> SignKmsMessageAsync(
            string issuerId,

            global::Vercel.SignKmsMessageRequest request,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Sign a message<br/>
        /// Sign a raw message with a KMS issuer's active signing key. Authenticate the request with a Vercel OIDC token in the `Authorization: Bearer` header; the issuer's policies decide which workloads are allowed to sign.
        /// </summary>
        /// <param name="issuerId">
        /// The ID of the issuer.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.SignKmsMessageResponse>> SignKmsMessageAsResponseAsync(
            string issuerId,

            global::Vercel.SignKmsMessageRequest request,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Sign a message<br/>
        /// Sign a raw message with a KMS issuer's active signing key. Authenticate the request with a Vercel OIDC token in the `Authorization: Bearer` header; the issuer's policies decide which workloads are allowed to sign.
        /// </summary>
        /// <param name="issuerId">
        /// The ID of the issuer.
        /// </param>
        /// <param name="message">
        /// Base64-encoded message to be signed.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.SignKmsMessageResponse> SignKmsMessageAsync(
            string issuerId,
            string message,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}