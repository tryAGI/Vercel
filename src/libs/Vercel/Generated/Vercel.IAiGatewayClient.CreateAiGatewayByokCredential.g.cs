#nullable enable

namespace Vercel
{
    public partial interface IAiGatewayClient
    {
        /// <summary>
        /// Create a BYOK credential<br/>
        /// Create a new BYOK credential
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
        global::System.Threading.Tasks.Task<global::Vercel.CreateAiGatewayByokCredentialResponse> CreateAiGatewayByokCredentialAsync(

            global::Vercel.CreateAiGatewayByokCredentialRequest request,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a BYOK credential<br/>
        /// Create a new BYOK credential
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
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.CreateAiGatewayByokCredentialResponse>> CreateAiGatewayByokCredentialAsResponseAsync(

            global::Vercel.CreateAiGatewayByokCredentialRequest request,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a BYOK credential<br/>
        /// Create a new BYOK credential
        /// </summary>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="ownerId">
        /// The owner ID for this credential. Ignored for customer tokens, which always create in their own team.
        /// </param>
        /// <param name="providerSlug">
        /// The provider slug this credential is for (e.g., "openai", "anthropic")
        /// </param>
        /// <param name="name">
        /// The developer-entered name for this credential
        /// </param>
        /// <param name="active">
        /// Whether the credential is active and can be used<br/>
        /// Default Value: true
        /// </param>
        /// <param name="zeroDataRetention">
        /// Whether the customer attested this external credential has a zero data retention policy<br/>
        /// Default Value: false
        /// </param>
        /// <param name="userId">
        /// The ID of the user performing this action, used for Activity-log attribution.
        /// </param>
        /// <param name="mappings">
        /// Model mappings to create atomically with the credential (e.g. Azure deployments). One DynamoDB transaction holds the credential plus all mappings, so at most 99 mappings fit.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.CreateAiGatewayByokCredentialResponse> CreateAiGatewayByokCredentialAsync(
            string providerSlug,
            string name,
            string? teamId = default,
            string? slug = default,
            string? ownerId = default,
            bool? active = default,
            bool? zeroDataRetention = default,
            string? userId = default,
            global::System.Collections.Generic.IList<global::Vercel.CreateAiGatewayByokCredentialRequestMapping>? mappings = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}