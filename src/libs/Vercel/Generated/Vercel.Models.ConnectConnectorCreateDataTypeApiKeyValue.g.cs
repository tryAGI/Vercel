
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConnectConnectorCreateDataTypeApiKeyValue
    {
        /// <summary>
        /// API key value.<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// Optional scope associated with the API key value.
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
        /// Initializes a new instance of the <see cref="ConnectConnectorCreateDataTypeApiKeyValue" /> class.
        /// </summary>
        /// <param name="value">
        /// API key value.<br/>
        /// Included only in requests
        /// </param>
        /// <param name="scope">
        /// Optional scope associated with the API key value.
        /// </param>
        /// <param name="expiresAt">
        /// The timestamp when the API key value expires in milliseconds.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConnectConnectorCreateDataTypeApiKeyValue(
            string? value,
            string? scope,
            int? expiresAt)
        {
            this.Value = value;
            this.Scope = scope;
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectConnectorCreateDataTypeApiKeyValue" /> class.
        /// </summary>
        public ConnectConnectorCreateDataTypeApiKeyValue()
        {
        }

    }
}