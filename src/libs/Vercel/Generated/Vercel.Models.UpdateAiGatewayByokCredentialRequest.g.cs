
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateAiGatewayByokCredentialRequest
    {
        /// <summary>
        /// The new name for the credential
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Whether the credential should be active
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Whether the customer attested this external credential has a zero data retention policy
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("zeroDataRetention")]
        public bool? ZeroDataRetention { get; set; }

        /// <summary>
        /// The ID of the user performing this action, used for Activity-log attribution.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        public string? UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAiGatewayByokCredentialRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The new name for the credential
        /// </param>
        /// <param name="active">
        /// Whether the credential should be active
        /// </param>
        /// <param name="zeroDataRetention">
        /// Whether the customer attested this external credential has a zero data retention policy
        /// </param>
        /// <param name="userId">
        /// The ID of the user performing this action, used for Activity-log attribution.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateAiGatewayByokCredentialRequest(
            string? name,
            bool? active,
            bool? zeroDataRetention,
            string? userId)
        {
            this.Name = name;
            this.Active = active;
            this.ZeroDataRetention = zeroDataRetention;
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAiGatewayByokCredentialRequest" /> class.
        /// </summary>
        public UpdateAiGatewayByokCredentialRequest()
        {
        }

    }
}