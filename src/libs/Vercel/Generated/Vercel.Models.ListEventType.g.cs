
#nullable enable

namespace Vercel
{
    /// <summary>
    /// A user-facing event type.
    /// </summary>
    public sealed partial class ListEventType
    {
        /// <summary>
        /// The name of the event type.<br/>
        /// Example: deployment-created
        /// </summary>
        /// <example>deployment-created</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.ListEventTypeNameJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.ListEventTypeName Name { get; set; }

        /// <summary>
        /// Description of the event, visible to users in the Activity dashboard and docs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Categories that group this event type with related event types.<br/>
        /// Example: [deployment]
        /// </summary>
        /// <example>[deployment]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("categories")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.ListEventTypeCategorie> Categories { get; set; }

        /// <summary>
        /// Present only when this event type is deprecated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deprecated")]
        public bool? Deprecated { get; set; }

        /// <summary>
        /// Event type names that supersede this deprecated event type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replacedBy")]
        public global::System.Collections.Generic.IList<global::Vercel.ListEventTypeReplacedByItem>? ReplacedBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListEventType" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the event type.<br/>
        /// Example: deployment-created
        /// </param>
        /// <param name="description">
        /// Description of the event, visible to users in the Activity dashboard and docs.
        /// </param>
        /// <param name="categories">
        /// Categories that group this event type with related event types.<br/>
        /// Example: [deployment]
        /// </param>
        /// <param name="deprecated">
        /// Present only when this event type is deprecated.
        /// </param>
        /// <param name="replacedBy">
        /// Event type names that supersede this deprecated event type.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListEventType(
            global::Vercel.ListEventTypeName name,
            string description,
            global::System.Collections.Generic.IList<global::Vercel.ListEventTypeCategorie> categories,
            bool? deprecated,
            global::System.Collections.Generic.IList<global::Vercel.ListEventTypeReplacedByItem>? replacedBy)
        {
            this.Name = name;
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Categories = categories ?? throw new global::System.ArgumentNullException(nameof(categories));
            this.Deprecated = deprecated;
            this.ReplacedBy = replacedBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListEventType" /> class.
        /// </summary>
        public ListEventType()
        {
        }

    }
}