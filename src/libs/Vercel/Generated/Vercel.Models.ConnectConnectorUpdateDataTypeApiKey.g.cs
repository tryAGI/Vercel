
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ConnectConnectorUpdateDataTypeApiKey
    {
        /// <summary>
        /// Stored API key value IDs to delete.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toDelete")]
        public global::System.Collections.Generic.IList<string>? ToDelete { get; set; }

        /// <summary>
        /// API key values to add.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toAdd")]
        public global::System.Collections.Generic.IList<global::Vercel.ConnectConnectorUpdateDataTypeApiKeyToAddItem>? ToAdd { get; set; }

        /// <summary>
        /// Existing API key values to update.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toUpdate")]
        public global::System.Collections.Generic.IList<global::Vercel.ConnectConnectorUpdateDataTypeApiKeyToUpdateItem>? ToUpdate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectConnectorUpdateDataTypeApiKey" /> class.
        /// </summary>
        /// <param name="toDelete">
        /// Stored API key value IDs to delete.
        /// </param>
        /// <param name="toAdd">
        /// API key values to add.
        /// </param>
        /// <param name="toUpdate">
        /// Existing API key values to update.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConnectConnectorUpdateDataTypeApiKey(
            global::System.Collections.Generic.IList<string>? toDelete,
            global::System.Collections.Generic.IList<global::Vercel.ConnectConnectorUpdateDataTypeApiKeyToAddItem>? toAdd,
            global::System.Collections.Generic.IList<global::Vercel.ConnectConnectorUpdateDataTypeApiKeyToUpdateItem>? toUpdate)
        {
            this.ToDelete = toDelete;
            this.ToAdd = toAdd;
            this.ToUpdate = toUpdate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectConnectorUpdateDataTypeApiKey" /> class.
        /// </summary>
        public ConnectConnectorUpdateDataTypeApiKey()
        {
        }

    }
}