
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateConnectorRequestDataTypeApiKeyValue
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        public string? Scope { get; set; }

        /// <summary>
        /// The timestamp when the API key value expires in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiresAt")]
        public int? ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectorRequestDataTypeApiKeyValue" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="scope"></param>
        /// <param name="expiresAt">
        /// The timestamp when the API key value expires in milliseconds.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateConnectorRequestDataTypeApiKeyValue(
            string value,
            string? scope,
            int? expiresAt)
        {
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.Scope = scope;
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectorRequestDataTypeApiKeyValue" /> class.
        /// </summary>
        public CreateConnectorRequestDataTypeApiKeyValue()
        {
        }

    }
}