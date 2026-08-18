
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateKmsIssuerRequestPolicyVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateKmsIssuerRequestPolicyVariant2KindJsonConverter))]
        public global::Vercel.CreateKmsIssuerRequestPolicyVariant2Kind Kind { get; set; }

        /// <summary>
        /// The Connex client ID for the Connex grant policy.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientId { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateKmsIssuerRequestPolicyVariant2" /> class.
        /// </summary>
        /// <param name="clientId">
        /// The Connex client ID for the Connex grant policy.
        /// </param>
        /// <param name="kind"></param>
        /// <param name="tokenClaims">
        /// The claims that KMS should include in signed JWTs for this policy.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateKmsIssuerRequestPolicyVariant2(
            string clientId,
            global::Vercel.CreateKmsIssuerRequestPolicyVariant2Kind kind,
            object? tokenClaims)
        {
            this.Kind = kind;
            this.ClientId = clientId ?? throw new global::System.ArgumentNullException(nameof(clientId));
            this.TokenClaims = tokenClaims;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateKmsIssuerRequestPolicyVariant2" /> class.
        /// </summary>
        public CreateKmsIssuerRequestPolicyVariant2()
        {
        }

    }
}