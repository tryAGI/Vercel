
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Provider synchronization errors, when synchronization is required.
    /// </summary>
    public sealed partial class ConnectServiceSyncError
    {
        /// <summary>
        /// Human-readable provider synchronization error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Connector fields that caused the synchronization error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fields")]
        public global::System.Collections.Generic.IList<string>? Fields { get; set; }

        /// <summary>
        /// Provider-specific error details that are safe to expose.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vendor")]
        public object? Vendor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectServiceSyncError" /> class.
        /// </summary>
        /// <param name="message">
        /// Human-readable provider synchronization error.
        /// </param>
        /// <param name="fields">
        /// Connector fields that caused the synchronization error.
        /// </param>
        /// <param name="vendor">
        /// Provider-specific error details that are safe to expose.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConnectServiceSyncError(
            string message,
            global::System.Collections.Generic.IList<string>? fields,
            object? vendor)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Fields = fields;
            this.Vendor = vendor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectServiceSyncError" /> class.
        /// </summary>
        public ConnectServiceSyncError()
        {
        }

    }
}