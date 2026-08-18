#nullable enable

namespace Vercel
{
    public partial interface IKmsClient
    {
        /// <summary>
        /// Create an issuer policy<br/>
        /// Attach a policy to a KMS issuer that grants a project's deployments permission to sign with it.
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
        global::System.Threading.Tasks.Task<global::Vercel.OneOf<global::Vercel.CreateKmsIssuerPolicyResponseVariant1, global::Vercel.CreateKmsIssuerPolicyResponseVariant2>> CreateKmsIssuerPolicyAsync(
            string issuerId,

            global::Vercel.CreateKmsIssuerPolicyRequest request,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an issuer policy<br/>
        /// Attach a policy to a KMS issuer that grants a project's deployments permission to sign with it.
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
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.OneOf<global::Vercel.CreateKmsIssuerPolicyResponseVariant1, global::Vercel.CreateKmsIssuerPolicyResponseVariant2>>> CreateKmsIssuerPolicyAsResponseAsync(
            string issuerId,

            global::Vercel.CreateKmsIssuerPolicyRequest request,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an issuer policy<br/>
        /// Attach a policy to a KMS issuer that grants a project's deployments permission to sign with it.
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
        /// <param name="kind"></param>
        /// <param name="projectId">
        /// The project ID for the project grant policy.
        /// </param>
        /// <param name="environments">
        /// The environments for the project grant policy. Each entry is a system environment (production, preview, development) or a custom environment ID (env_...).
        /// </param>
        /// <param name="tokenClaims">
        /// The claims that KMS should include in signed JWTs for this policy.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.OneOf<global::Vercel.CreateKmsIssuerPolicyResponseVariant1, global::Vercel.CreateKmsIssuerPolicyResponseVariant2>> CreateKmsIssuerPolicyAsync(
            string issuerId,
            string projectId,
            global::System.Collections.Generic.IList<string> environments,
            string? teamId = default,
            string? slug = default,
            global::Vercel.CreateKmsIssuerPolicyRequestKind kind = default,
            object? tokenClaims = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}