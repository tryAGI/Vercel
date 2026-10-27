#nullable enable

namespace Vercel
{
    public partial interface IAiGatewayClient
    {
        /// <summary>
        /// Update a BYOK credential<br/>
        /// Update a BYOK credential. Send `credential` to replace the key value in place, which keeps the credential ID, settings and model mappings.
        /// </summary>
        /// <param name="ownerId"></param>
        /// <param name="credentialId">
        /// The unique ID of the credential to update
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
        global::System.Threading.Tasks.Task<global::Vercel.UpdateAiGatewayByokCredentialResponse> UpdateAiGatewayByokCredentialAsync(
            string credentialId,

            global::Vercel.UpdateAiGatewayByokCredentialRequest request,
            string? ownerId = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a BYOK credential<br/>
        /// Update a BYOK credential. Send `credential` to replace the key value in place, which keeps the credential ID, settings and model mappings.
        /// </summary>
        /// <param name="ownerId"></param>
        /// <param name="credentialId">
        /// The unique ID of the credential to update
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
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.UpdateAiGatewayByokCredentialResponse>> UpdateAiGatewayByokCredentialAsResponseAsync(
            string credentialId,

            global::Vercel.UpdateAiGatewayByokCredentialRequest request,
            string? ownerId = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a BYOK credential<br/>
        /// Update a BYOK credential. Send `credential` to replace the key value in place, which keeps the credential ID, settings and model mappings.
        /// </summary>
        /// <param name="ownerId"></param>
        /// <param name="credentialId">
        /// The unique ID of the credential to update
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="name">
        /// The new name for the credential
        /// </param>
        /// <param name="active">
        /// Whether the credential should be active
        /// </param>
        /// <param name="zeroDataRetention">
        /// Whether the customer attested this external credential has a zero data retention policy
        /// </param>
        /// <param name="userId">
        /// The ID of the user performing this action, used for Activity-log attribution.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.UpdateAiGatewayByokCredentialResponse> UpdateAiGatewayByokCredentialAsync(
            string credentialId,
            string? ownerId = default,
            string? teamId = default,
            string? slug = default,
            string? name = default,
            bool? active = default,
            bool? zeroDataRetention = default,
            string? userId = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}