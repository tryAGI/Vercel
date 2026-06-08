
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Set by `?include=projects`. Capped at 100 per client.
    /// </summary>
    public sealed partial class CreateConnectorResponseIncludesProjects
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.CreateConnectorResponseIncludesProjectsItem> Items { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hasMore")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cursor")]
        public string? Cursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectorResponseIncludesProjects" /> class.
        /// </summary>
        /// <param name="items"></param>
        /// <param name="hasMore"></param>
        /// <param name="cursor"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateConnectorResponseIncludesProjects(
            global::System.Collections.Generic.IList<global::Vercel.CreateConnectorResponseIncludesProjectsItem> items,
            bool hasMore,
            string? cursor)
        {
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.HasMore = hasMore;
            this.Cursor = cursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectorResponseIncludesProjects" /> class.
        /// </summary>
        public CreateConnectorResponseIncludesProjects()
        {
        }

    }
}