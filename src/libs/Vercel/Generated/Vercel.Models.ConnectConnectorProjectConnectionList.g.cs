
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Page of projects connected to a connector.
    /// </summary>
    public sealed partial class ConnectConnectorProjectConnectionList
    {
        /// <summary>
        /// Project connections in this page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projects")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.ConnectProjectConnection> Projects { get; set; }

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
        /// Initializes a new instance of the <see cref="ConnectConnectorProjectConnectionList" /> class.
        /// </summary>
        /// <param name="projects">
        /// Project connections in this page.
        /// </param>
        /// <param name="pagination">
        /// Cursor for the next page.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConnectConnectorProjectConnectionList(
            global::System.Collections.Generic.IList<global::Vercel.ConnectProjectConnection> projects,
            global::Vercel.ConnectPagination pagination)
        {
            this.Projects = projects ?? throw new global::System.ArgumentNullException(nameof(projects));
            this.Pagination = pagination ?? throw new global::System.ArgumentNullException(nameof(pagination));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectConnectorProjectConnectionList" /> class.
        /// </summary>
        public ConnectConnectorProjectConnectionList()
        {
        }

    }
}