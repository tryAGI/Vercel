#nullable enable

namespace Vercel
{
    public partial interface IAiGatewayClient
    {
        /// <summary>
        /// List BYOK credentials<br/>
        /// List BYOK credentials for an owner, optionally filtered by provider
        /// </summary>
        /// <param name="ownerId">
        /// The owner ID to list credentials for. Ignored for customer tokens, which always list their own team.
        /// </param>
        /// <param name="providerSlug">
        /// Optional provider slug to filter credentials by
        /// </param>
        /// <param name="includeDeleted">
        /// Whether to include soft-deleted credentials<br/>
        /// Default Value: false
        /// </param>
        /// <param name="decrypt">
        /// Not supported. Credential values are never returned.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeModelMappings">
        /// Whether to include model mappings for each credential in the response<br/>
        /// Default Value: false
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
        global::System.Threading.Tasks.Task<global::Vercel.ListAiGatewayByokCredentialsResponse> ListAiGatewayByokCredentialsAsync(
            string? ownerId = default,
            string? providerSlug = default,
            global::Vercel.ListAiGatewayByokCredentialsIncludeDeleted? includeDeleted = default,
            global::Vercel.ListAiGatewayByokCredentialsDecrypt? decrypt = default,
            global::Vercel.ListAiGatewayByokCredentialsIncludeModelMappings? includeModelMappings = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List BYOK credentials<br/>
        /// List BYOK credentials for an owner, optionally filtered by provider
        /// </summary>
        /// <param name="ownerId">
        /// The owner ID to list credentials for. Ignored for customer tokens, which always list their own team.
        /// </param>
        /// <param name="providerSlug">
        /// Optional provider slug to filter credentials by
        /// </param>
        /// <param name="includeDeleted">
        /// Whether to include soft-deleted credentials<br/>
        /// Default Value: false
        /// </param>
        /// <param name="decrypt">
        /// Not supported. Credential values are never returned.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeModelMappings">
        /// Whether to include model mappings for each credential in the response<br/>
        /// Default Value: false
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
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.ListAiGatewayByokCredentialsResponse>> ListAiGatewayByokCredentialsAsResponseAsync(
            string? ownerId = default,
            string? providerSlug = default,
            global::Vercel.ListAiGatewayByokCredentialsIncludeDeleted? includeDeleted = default,
            global::Vercel.ListAiGatewayByokCredentialsDecrypt? decrypt = default,
            global::Vercel.ListAiGatewayByokCredentialsIncludeModelMappings? includeModelMappings = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}