
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Lets the integration-tokens service sign marketplace resource tokens for one integration (`oac_…`).
    /// </summary>
    public sealed partial class CreateKmsIssuerPolicyResponseVariant3
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IntegrationId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateKmsIssuerPolicyResponseVariant3KindJsonConverter))]
        public global::Vercel.CreateKmsIssuerPolicyResponseVariant3Kind Kind { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokenClaims")]
        public object? TokenClaims { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateKmsIssuerPolicyResponseVariant3" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="integrationId"></param>
        /// <param name="updatedAt"></param>
        /// <param name="kind"></param>
        /// <param name="tokenClaims"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateKmsIssuerPolicyResponseVariant3(
            string createdAt,
            string integrationId,
            string updatedAt,
            global::Vercel.CreateKmsIssuerPolicyResponseVariant3Kind kind,
            object? tokenClaims)
        {
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.IntegrationId = integrationId ?? throw new global::System.ArgumentNullException(nameof(integrationId));
            this.Kind = kind;
            this.TokenClaims = tokenClaims;
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateKmsIssuerPolicyResponseVariant3" /> class.
        /// </summary>
        public CreateKmsIssuerPolicyResponseVariant3()
        {
        }

    }
}