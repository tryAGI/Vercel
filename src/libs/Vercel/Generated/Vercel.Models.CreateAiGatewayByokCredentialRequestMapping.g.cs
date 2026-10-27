
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateAiGatewayByokCredentialRequestMapping
    {
        /// <summary>
        /// The AI Gateway model slug (e.g., "openai/gpt-5.4")
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gatewayModelSlug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GatewayModelSlug { get; set; }

        /// <summary>
        /// The customer's custom model ID (e.g., "my-finetuned-gpt-5")
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customModelId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CustomModelId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAiGatewayByokCredentialRequestMapping" /> class.
        /// </summary>
        /// <param name="gatewayModelSlug">
        /// The AI Gateway model slug (e.g., "openai/gpt-5.4")
        /// </param>
        /// <param name="customModelId">
        /// The customer's custom model ID (e.g., "my-finetuned-gpt-5")
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAiGatewayByokCredentialRequestMapping(
            string gatewayModelSlug,
            string customModelId)
        {
            this.GatewayModelSlug = gatewayModelSlug ?? throw new global::System.ArgumentNullException(nameof(gatewayModelSlug));
            this.CustomModelId = customModelId ?? throw new global::System.ArgumentNullException(nameof(customModelId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAiGatewayByokCredentialRequestMapping" /> class.
        /// </summary>
        public CreateAiGatewayByokCredentialRequestMapping()
        {
        }

    }
}