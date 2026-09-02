
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ConnectConnectorUpdateDataTypeApiKeyToUpdateItem
    {
        /// <summary>
        /// Stored API key value ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Replacement API key value. Use null to keep the stored value.<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// Replacement scope. Use null to remove the scope.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        public string? Scope { get; set; }

        /// <summary>
        /// The timestamp when the API key value expires in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiresAt")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AnyOfJsonConverter<int?, string>))]
        public global::Vercel.AnyOf<int?, string>? ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectConnectorUpdateDataTypeApiKeyToUpdateItem" /> class.
        /// </summary>
        /// <param name="id">
        /// Stored API key value ID.
        /// </param>
        /// <param name="value">
        /// Replacement API key value. Use null to keep the stored value.<br/>
        /// Included only in requests
        /// </param>
        /// <param name="scope">
        /// Replacement scope. Use null to remove the scope.
        /// </param>
        /// <param name="expiresAt">
        /// The timestamp when the API key value expires in milliseconds.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConnectConnectorUpdateDataTypeApiKeyToUpdateItem(
            string id,
            string? value,
            string? scope,
            global::Vercel.AnyOf<int?, string>? expiresAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Value = value;
            this.Scope = scope;
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectConnectorUpdateDataTypeApiKeyToUpdateItem" /> class.
        /// </summary>
        public ConnectConnectorUpdateDataTypeApiKeyToUpdateItem()
        {
        }

    }
}