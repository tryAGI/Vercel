
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateApiKeysRequest
    {
        /// <summary>
        /// The API key's purpose, which restricts how it can be used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("purpose")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Purpose { get; set; }

        /// <summary>
        /// An optional project to restrict the API key to.<br/>
        /// Example: prj_12HKQaOmR5t5Uy6vdcQsNIiZgHGB
        /// </summary>
        /// <example>prj_12HKQaOmR5t5Uy6vdcQsNIiZgHGB</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// An optional name for the API key.<br/>
        /// Example: API Key for App 123
        /// </summary>
        /// <example>API Key for App 123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The API key's expiration, expressed as a UNIX timestamp in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiresAt")]
        public double? ExpiresAt { get; set; }

        /// <summary>
        /// Optional AI Gateway quota configuration for the API key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aiGatewayQuota")]
        public global::Vercel.CreateApiKeysRequestAiGatewayQuota? AiGatewayQuota { get; set; }

        /// <summary>
        /// Optional generic metadata for the API key. The accepted shape depends on the key's `purpose` and is validated on creation; for `ai-gateway` keys this accepts `environment`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateApiKeysRequest" /> class.
        /// </summary>
        /// <param name="purpose">
        /// The API key's purpose, which restricts how it can be used.
        /// </param>
        /// <param name="projectId">
        /// An optional project to restrict the API key to.<br/>
        /// Example: prj_12HKQaOmR5t5Uy6vdcQsNIiZgHGB
        /// </param>
        /// <param name="name">
        /// An optional name for the API key.<br/>
        /// Example: API Key for App 123
        /// </param>
        /// <param name="expiresAt">
        /// The API key's expiration, expressed as a UNIX timestamp in milliseconds.
        /// </param>
        /// <param name="aiGatewayQuota">
        /// Optional AI Gateway quota configuration for the API key.
        /// </param>
        /// <param name="metadata">
        /// Optional generic metadata for the API key. The accepted shape depends on the key's `purpose` and is validated on creation; for `ai-gateway` keys this accepts `environment`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateApiKeysRequest(
            string purpose,
            string? projectId,
            string? name,
            double? expiresAt,
            global::Vercel.CreateApiKeysRequestAiGatewayQuota? aiGatewayQuota,
            object? metadata)
        {
            this.Purpose = purpose ?? throw new global::System.ArgumentNullException(nameof(purpose));
            this.ProjectId = projectId;
            this.Name = name;
            this.ExpiresAt = expiresAt;
            this.AiGatewayQuota = aiGatewayQuota;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateApiKeysRequest" /> class.
        /// </summary>
        public CreateApiKeysRequest()
        {
        }

    }
}