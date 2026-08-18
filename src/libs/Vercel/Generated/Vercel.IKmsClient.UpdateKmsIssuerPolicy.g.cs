#nullable enable

namespace Vercel
{
    public partial interface IKmsClient
    {
        /// <summary>
        /// Update an issuer policy<br/>
        /// Update an existing KMS issuer policy's environments or token claims.
        /// </summary>
        /// <param name="issuerId">
        /// The ID of the issuer.
        /// </param>
        /// <param name="kind">
        /// The issuer policy kind.
        /// </param>
        /// <param name="policyKey">
        /// The policy identifier.
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
        global::System.Threading.Tasks.Task<global::Vercel.OneOf<global::Vercel.UpdateKmsIssuerPolicyResponseVariant1, global::Vercel.UpdateKmsIssuerPolicyResponseVariant2>> UpdateKmsIssuerPolicyAsync(
            string issuerId,
            global::Vercel.UpdateKmsIssuerPolicyKind kind,
            string policyKey,

            global::Vercel.UpdateKmsIssuerPolicyRequest request,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an issuer policy<br/>
        /// Update an existing KMS issuer policy's environments or token claims.
        /// </summary>
        /// <param name="issuerId">
        /// The ID of the issuer.
        /// </param>
        /// <param name="kind">
        /// The issuer policy kind.
        /// </param>
        /// <param name="policyKey">
        /// The policy identifier.
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
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.OneOf<global::Vercel.UpdateKmsIssuerPolicyResponseVariant1, global::Vercel.UpdateKmsIssuerPolicyResponseVariant2>>> UpdateKmsIssuerPolicyAsResponseAsync(
            string issuerId,
            global::Vercel.UpdateKmsIssuerPolicyKind kind,
            string policyKey,

            global::Vercel.UpdateKmsIssuerPolicyRequest request,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an issuer policy<br/>
        /// Update an existing KMS issuer policy's environments or token claims.
        /// </summary>
        /// <param name="issuerId">
        /// The ID of the issuer.
        /// </param>
        /// <param name="kind">
        /// The issuer policy kind.
        /// </param>
        /// <param name="policyKey">
        /// The policy identifier.
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="environments">
        /// The environments for the project grant policy. Each entry is a system environment (production, preview, development) or a custom environment ID (env_...).
        /// </param>
        /// <param name="tokenClaims">
        /// The claims that KMS should include in signed JWTs for this policy. Pass null to remove them.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.OneOf<global::Vercel.UpdateKmsIssuerPolicyResponseVariant1, global::Vercel.UpdateKmsIssuerPolicyResponseVariant2>> UpdateKmsIssuerPolicyAsync(
            string issuerId,
            global::Vercel.UpdateKmsIssuerPolicyKind kind,
            string policyKey,
            string? teamId = default,
            string? slug = default,
            global::System.Collections.Generic.IList<string>? environments = default,
            object? tokenClaims = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}