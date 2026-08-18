#nullable enable

namespace Vercel
{
    public partial interface IKmsClient
    {
        /// <summary>
        /// Create a signing key<br/>
        /// Create a new signing key for a KMS issuer. Depending on the activation mode, the key is activated automatically once its public key has propagated, or manually via the activate endpoint.
        /// </summary>
        /// <param name="issuerId">
        /// The ID of the issuer.
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.CreateKmsSigningKeyResponse> CreateKmsSigningKeyAsync(
            string issuerId,

            global::Vercel.CreateKmsSigningKeyRequest request,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a signing key<br/>
        /// Create a new signing key for a KMS issuer. Depending on the activation mode, the key is activated automatically once its public key has propagated, or manually via the activate endpoint.
        /// </summary>
        /// <param name="issuerId">
        /// The ID of the issuer.
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.CreateKmsSigningKeyResponse>> CreateKmsSigningKeyAsResponseAsync(
            string issuerId,

            global::Vercel.CreateKmsSigningKeyRequest request,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a signing key<br/>
        /// Create a new signing key for a KMS issuer. Depending on the activation mode, the key is activated automatically once its public key has propagated, or manually via the activate endpoint.
        /// </summary>
        /// <param name="issuerId">
        /// The ID of the issuer.
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="activation">
        /// Whether the new key is activated automatically after its public key has propagated, or manually via the activate endpoint. Defaults to `automatic`.
        /// </param>
        /// <param name="revokePreviousAfterHours">
        /// For automatic activation, how many hours after activation the previous signing key should stop being used. Defaults to a 1 hour grace period so already-issued tokens keep verifying.
        /// </param>
        /// <param name="revokePreviousAt">
        /// Deprecated. The ISO date string or timestamp when the previous signing key should stop being used. Converted to a relative grace and applied at activation, not creation. Prefer revokePreviousAfterHours.
        /// </param>
        /// <param name="importKey">
        /// The PEM-encoded private key to use for the issuer.
        /// </param>
        /// <param name="importKeyId">
        /// The key id to use as the imported key's JWT/JWKS `kid`. Only allowed when `importKey` is provided. Not required to be unique; the addressable key id is the server-minted `keyId` returned in the response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.CreateKmsSigningKeyResponse> CreateKmsSigningKeyAsync(
            string issuerId,
            string? teamId = default,
            string? slug = default,
            global::Vercel.CreateKmsSigningKeyRequestActivation? activation = default,
            double? revokePreviousAfterHours = default,
            global::Vercel.OneOf<string, double?>? revokePreviousAt = default,
            string? importKey = default,
            string? importKeyId = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}