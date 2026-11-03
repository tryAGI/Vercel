
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateKmsIssuerRequestPolicyVariant3
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateKmsIssuerRequestPolicyVariant3KindJsonConverter))]
        public global::Vercel.CreateKmsIssuerRequestPolicyVariant3Kind Kind { get; set; }

        /// <summary>
        /// The marketplace integration ID for the integration tokens grant policy.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IntegrationId { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateKmsIssuerRequestPolicyVariant3" /> class.
        /// </summary>
        /// <param name="integrationId">
        /// The marketplace integration ID for the integration tokens grant policy.
        /// </param>
        /// <param name="kind"></param>
        /// <param name="tokenClaims">
        /// The claims that KMS should include in signed JWTs for this policy.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateKmsIssuerRequestPolicyVariant3(
            string integrationId,
            global::Vercel.CreateKmsIssuerRequestPolicyVariant3Kind kind,
            object? tokenClaims)
        {
            this.Kind = kind;
            this.IntegrationId = integrationId ?? throw new global::System.ArgumentNullException(nameof(integrationId));
            this.TokenClaims = tokenClaims;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateKmsIssuerRequestPolicyVariant3" /> class.
        /// </summary>
        public CreateKmsIssuerRequestPolicyVariant3()
        {
        }

    }
}