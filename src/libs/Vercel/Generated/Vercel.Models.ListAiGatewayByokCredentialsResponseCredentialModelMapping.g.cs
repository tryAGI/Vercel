
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListAiGatewayByokCredentialsResponseCredentialModelMapping
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customModelId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CustomModelId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gatewayModelSlug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GatewayModelSlug { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAiGatewayByokCredentialsResponseCredentialModelMapping" /> class.
        /// </summary>
        /// <param name="customModelId"></param>
        /// <param name="gatewayModelSlug"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListAiGatewayByokCredentialsResponseCredentialModelMapping(
            string customModelId,
            string gatewayModelSlug)
        {
            this.CustomModelId = customModelId ?? throw new global::System.ArgumentNullException(nameof(customModelId));
            this.GatewayModelSlug = gatewayModelSlug ?? throw new global::System.ArgumentNullException(nameof(gatewayModelSlug));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAiGatewayByokCredentialsResponseCredentialModelMapping" /> class.
        /// </summary>
        public ListAiGatewayByokCredentialsResponseCredentialModelMapping()
        {
        }

    }
}