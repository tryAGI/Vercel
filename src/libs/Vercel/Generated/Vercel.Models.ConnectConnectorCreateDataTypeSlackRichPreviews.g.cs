
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Work Object preview settings for the managed Slack app. Updates preserve omitted settings.
    /// </summary>
    public sealed partial class ConnectConnectorCreateDataTypeSlackRichPreviews
    {
        /// <summary>
        /// Enable Work Object previews. Defaults to false for new apps.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isActive")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Entity types to preview. An empty array clears the configured types.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entityTypes")]
        public global::System.Collections.Generic.IList<string>? EntityTypes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectConnectorCreateDataTypeSlackRichPreviews" /> class.
        /// </summary>
        /// <param name="isActive">
        /// Enable Work Object previews. Defaults to false for new apps.
        /// </param>
        /// <param name="entityTypes">
        /// Entity types to preview. An empty array clears the configured types.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConnectConnectorCreateDataTypeSlackRichPreviews(
            bool? isActive,
            global::System.Collections.Generic.IList<string>? entityTypes)
        {
            this.IsActive = isActive;
            this.EntityTypes = entityTypes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectConnectorCreateDataTypeSlackRichPreviews" /> class.
        /// </summary>
        public ConnectConnectorCreateDataTypeSlackRichPreviews()
        {
        }

    }
}