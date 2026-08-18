#nullable enable

namespace Vercel
{
    public partial interface IKmsClient
    {
        /// <summary>
        /// Update an issuer<br/>
        /// Update a KMS issuer's name or claims schema.
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
        global::System.Threading.Tasks.Task<global::Vercel.UpdateKmsIssuerResponse> UpdateKmsIssuerAsync(
            string issuerId,

            global::Vercel.UpdateKmsIssuerRequest request,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an issuer<br/>
        /// Update a KMS issuer's name or claims schema.
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
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.UpdateKmsIssuerResponse>> UpdateKmsIssuerAsResponseAsync(
            string issuerId,

            global::Vercel.UpdateKmsIssuerRequest request,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an issuer<br/>
        /// Update a KMS issuer's name or claims schema.
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
        /// <param name="name">
        /// The name of the issuer.
        /// </param>
        /// <param name="claimsSchema">
        /// A JSON Schema used to validate the resolved token claims when signing tokens for this issuer. Pass null to remove it.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.UpdateKmsIssuerResponse> UpdateKmsIssuerAsync(
            string issuerId,
            string? teamId = default,
            string? slug = default,
            string? name = default,
            object? claimsSchema = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}