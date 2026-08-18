#nullable enable

namespace Vercel
{
    public partial interface IKmsClient
    {
        /// <summary>
        /// Create an issuer<br/>
        /// Create a new KMS issuer for the authenticated team. An issuer owns the asymmetric signing keys that are used to sign tokens and messages.
        /// </summary>
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
        global::System.Threading.Tasks.Task<global::Vercel.CreateKmsIssuerResponse> CreateKmsIssuerAsync(

            global::Vercel.CreateKmsIssuerRequest request,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an issuer<br/>
        /// Create a new KMS issuer for the authenticated team. An issuer owns the asymmetric signing keys that are used to sign tokens and messages.
        /// </summary>
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
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.CreateKmsIssuerResponse>> CreateKmsIssuerAsResponseAsync(

            global::Vercel.CreateKmsIssuerRequest request,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an issuer<br/>
        /// Create a new KMS issuer for the authenticated team. An issuer owns the asymmetric signing keys that are used to sign tokens and messages.
        /// </summary>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="name">
        /// The name of the issuer.
        /// </param>
        /// <param name="algorithm">
        /// The signing algorithm to use for the issuer.<br/>
        /// Default Value: RS512
        /// </param>
        /// <param name="claimsSchema">
        /// A JSON Schema used to validate the resolved token claims when signing tokens for this issuer.
        /// </param>
        /// <param name="policy"></param>
        /// <param name="importKey">
        /// The PEM-encoded private key to use for the issuer.
        /// </param>
        /// <param name="importKeyId">
        /// The key id to use as the imported key's JWT/JWKS `kid`. Only allowed when `importKey` is provided. Not required to be unique; the addressable key id is the server-minted `keyId` returned in the response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.CreateKmsIssuerResponse> CreateKmsIssuerAsync(
            string name,
            string? teamId = default,
            string? slug = default,
            global::Vercel.CreateKmsIssuerRequestAlgorithm? algorithm = default,
            object? claimsSchema = default,
            global::Vercel.OneOf<global::Vercel.CreateKmsIssuerRequestPolicyVariant1, global::Vercel.CreateKmsIssuerRequestPolicyVariant2>? policy = default,
            string? importKey = default,
            string? importKeyId = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}