
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateKmsIssuerPolicyRequest
    {
        /// <summary>
        /// The environments for the project grant policy. Each entry is a system environment (production, preview, development) or a custom environment ID (env_...).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environments")]
        public global::System.Collections.Generic.IList<string>? Environments { get; set; }

        /// <summary>
        /// The claims that KMS should include in signed JWTs for this policy. Pass null to remove them.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokenClaims")]
        public object? TokenClaims { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateKmsIssuerPolicyRequest" /> class.
        /// </summary>
        /// <param name="environments">
        /// The environments for the project grant policy. Each entry is a system environment (production, preview, development) or a custom environment ID (env_...).
        /// </param>
        /// <param name="tokenClaims">
        /// The claims that KMS should include in signed JWTs for this policy. Pass null to remove them.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateKmsIssuerPolicyRequest(
            global::System.Collections.Generic.IList<string>? environments,
            object? tokenClaims)
        {
            this.Environments = environments;
            this.TokenClaims = tokenClaims;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateKmsIssuerPolicyRequest" /> class.
        /// </summary>
        public UpdateKmsIssuerPolicyRequest()
        {
        }

    }
}