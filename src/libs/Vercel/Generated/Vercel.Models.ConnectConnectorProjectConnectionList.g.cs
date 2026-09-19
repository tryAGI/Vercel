
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Page of projects connected to a connector.
    /// </summary>
    public sealed partial class ConnectConnectorProjectConnectionList
    {
        /// <summary>
        /// Cursor for the next page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pagination")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.ConnectPagination Pagination { get; set; }

        /// <summary>
        /// Project connections in this page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projects")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.ConnectProjectConnection> Projects { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectConnectorProjectConnectionList" /> class.
        /// </summary>
        /// <param name="pagination">
        /// Cursor for the next page.
        /// </param>
        /// <param name="projects">
        /// Project connections in this page.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConnectConnectorProjectConnectionList(
            global::Vercel.ConnectPagination pagination,
            global::System.Collections.Generic.IList<global::Vercel.ConnectProjectConnection> projects)
        {
            this.Pagination = pagination ?? throw new global::System.ArgumentNullException(nameof(pagination));
            this.Projects = projects ?? throw new global::System.ArgumentNullException(nameof(projects));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectConnectorProjectConnectionList" /> class.
        /// </summary>
        public ConnectConnectorProjectConnectionList()
        {
        }

    }
}