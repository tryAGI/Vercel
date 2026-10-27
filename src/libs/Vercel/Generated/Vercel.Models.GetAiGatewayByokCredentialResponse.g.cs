
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetAiGatewayByokCredentialResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Active { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credentialId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CredentialId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastFourChars")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LastFourChars { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ownerId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OwnerId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerSlug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProviderSlug { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UpdatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("zeroDataRetention")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ZeroDataRetention { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAiGatewayByokCredentialResponse" /> class.
        /// </summary>
        /// <param name="active"></param>
        /// <param name="createdAt"></param>
        /// <param name="credentialId"></param>
        /// <param name="lastFourChars"></param>
        /// <param name="name"></param>
        /// <param name="ownerId"></param>
        /// <param name="providerSlug"></param>
        /// <param name="updatedAt"></param>
        /// <param name="zeroDataRetention"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAiGatewayByokCredentialResponse(
            bool active,
            double createdAt,
            string credentialId,
            string lastFourChars,
            string name,
            string ownerId,
            string providerSlug,
            double updatedAt,
            bool zeroDataRetention)
        {
            this.Active = active;
            this.CreatedAt = createdAt;
            this.CredentialId = credentialId ?? throw new global::System.ArgumentNullException(nameof(credentialId));
            this.LastFourChars = lastFourChars ?? throw new global::System.ArgumentNullException(nameof(lastFourChars));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.OwnerId = ownerId ?? throw new global::System.ArgumentNullException(nameof(ownerId));
            this.ProviderSlug = providerSlug ?? throw new global::System.ArgumentNullException(nameof(providerSlug));
            this.UpdatedAt = updatedAt;
            this.ZeroDataRetention = zeroDataRetention;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAiGatewayByokCredentialResponse" /> class.
        /// </summary>
        public GetAiGatewayByokCredentialResponse()
        {
        }

    }
}