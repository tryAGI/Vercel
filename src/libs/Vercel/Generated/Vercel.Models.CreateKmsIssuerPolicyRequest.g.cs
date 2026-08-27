
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateKmsIssuerPolicyRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateKmsIssuerPolicyRequestKindJsonConverter))]
        public global::Vercel.CreateKmsIssuerPolicyRequestKind Kind { get; set; }

        /// <summary>
        /// The project ID for the project grant policy.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// The environments for the project grant policy. Each entry is a system environment (production, preview, development) or a custom environment ID (env_...).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Environments { get; set; }

        /// <summary>
        /// The claims that KMS should include in signed JWTs for this policy.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokenClaims")]
        public object? TokenClaims { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateKmsIssuerPolicyRequest" /> class.
        /// </summary>
        /// <param name="projectId">
        /// The project ID for the project grant policy.
        /// </param>
        /// <param name="environments">
        /// The environments for the project grant policy. Each entry is a system environment (production, preview, development) or a custom environment ID (env_...).
        /// </param>
        /// <param name="kind"></param>
        /// <param name="tokenClaims">
        /// The claims that KMS should include in signed JWTs for this policy.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateKmsIssuerPolicyRequest(
            string projectId,
            global::System.Collections.Generic.IList<string> environments,
            global::Vercel.CreateKmsIssuerPolicyRequestKind kind,
            object? tokenClaims)
        {
            this.Kind = kind;
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Environments = environments ?? throw new global::System.ArgumentNullException(nameof(environments));
            this.TokenClaims = tokenClaims;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateKmsIssuerPolicyRequest" /> class.
        /// </summary>
        public CreateKmsIssuerPolicyRequest()
        {
        }

    }
}