
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateAiGatewayByokCredentialRequest
    {
        /// <summary>
        /// The owner ID for this credential. Ignored for customer tokens, which always create in their own team.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ownerId")]
        public string? OwnerId { get; set; }

        /// <summary>
        /// The provider slug this credential is for (e.g., "openai", "anthropic")
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerSlug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProviderSlug { get; set; }

        /// <summary>
        /// The developer-entered name for this credential
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Whether the credential is active and can be used<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Whether the customer attested this external credential has a zero data retention policy<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("zeroDataRetention")]
        public bool? ZeroDataRetention { get; set; }

        /// <summary>
        /// The ID of the user performing this action, used for Activity-log attribution.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        public string? UserId { get; set; }

        /// <summary>
        /// Model mappings to create atomically with the credential (e.g. Azure deployments). One DynamoDB transaction holds the credential plus all mappings, so at most 99 mappings fit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mappings")]
        public global::System.Collections.Generic.IList<global::Vercel.CreateAiGatewayByokCredentialRequestMapping>? Mappings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAiGatewayByokCredentialRequest" /> class.
        /// </summary>
        /// <param name="providerSlug">
        /// The provider slug this credential is for (e.g., "openai", "anthropic")
        /// </param>
        /// <param name="name">
        /// The developer-entered name for this credential
        /// </param>
        /// <param name="ownerId">
        /// The owner ID for this credential. Ignored for customer tokens, which always create in their own team.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAiGatewayByokCredentialRequest(
            string providerSlug,
            string name,
            string? ownerId,
            bool? active,
            bool? zeroDataRetention,
            string? userId,
            global::System.Collections.Generic.IList<global::Vercel.CreateAiGatewayByokCredentialRequestMapping>? mappings)
        {
            this.OwnerId = ownerId;
            this.ProviderSlug = providerSlug ?? throw new global::System.ArgumentNullException(nameof(providerSlug));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Active = active;
            this.ZeroDataRetention = zeroDataRetention;
            this.UserId = userId;
            this.Mappings = mappings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAiGatewayByokCredentialRequest" /> class.
        /// </summary>
        public CreateAiGatewayByokCredentialRequest()
        {
        }

    }
}