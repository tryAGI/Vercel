#nullable enable

namespace Vercel
{
    public partial interface IAiGatewayClient
    {
        /// <summary>
        /// Delete a BYOK credential<br/>
        /// Delete a BYOK credential (soft delete) and its model mappings
        /// </summary>
        /// <param name="ownerId"></param>
        /// <param name="credentialId">
        /// The unique ID of the credential to delete
        /// </param>
        /// <param name="userId">
        /// The ID of the user performing this action, used for Activity-log attribution.
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteAiGatewayByokCredentialAsync(
            string credentialId,
            string? ownerId = default,
            string? userId = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a BYOK credential<br/>
        /// Delete a BYOK credential (soft delete) and its model mappings
        /// </summary>
        /// <param name="ownerId"></param>
        /// <param name="credentialId">
        /// The unique ID of the credential to delete
        /// </param>
        /// <param name="userId">
        /// The ID of the user performing this action, used for Activity-log attribution.
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<string>> DeleteAiGatewayByokCredentialAsResponseAsync(
            string credentialId,
            string? ownerId = default,
            string? userId = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}