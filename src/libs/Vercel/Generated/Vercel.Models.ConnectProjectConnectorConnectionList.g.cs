
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Page of connectors connected to a project.
    /// </summary>
    public sealed partial class ConnectProjectConnectorConnectionList
    {
        /// <summary>
        /// Connector connections in this page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.ConnectProjectConnection> Connectors { get; set; }

        /// <summary>
        /// Cursor for the next page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pagination")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.ConnectPagination Pagination { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectProjectConnectorConnectionList" /> class.
        /// </summary>
        /// <param name="connectors">
        /// Connector connections in this page.
        /// </param>
        /// <param name="pagination">
        /// Cursor for the next page.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConnectProjectConnectorConnectionList(
            global::System.Collections.Generic.IList<global::Vercel.ConnectProjectConnection> connectors,
            global::Vercel.ConnectPagination pagination)
        {
            this.Connectors = connectors ?? throw new global::System.ArgumentNullException(nameof(connectors));
            this.Pagination = pagination ?? throw new global::System.ArgumentNullException(nameof(pagination));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectProjectConnectorConnectionList" /> class.
        /// </summary>
        public ConnectProjectConnectorConnectionList()
        {
        }

    }
}