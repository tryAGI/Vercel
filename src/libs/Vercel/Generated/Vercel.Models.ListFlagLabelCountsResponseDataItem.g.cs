
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListFlagLabelCountsResponseDataItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributeKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AttributeKey { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entityKind")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EntityKind { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Count { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListFlagLabelCountsResponseDataItem" /> class.
        /// </summary>
        /// <param name="attributeKey"></param>
        /// <param name="entityKind"></param>
        /// <param name="count"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListFlagLabelCountsResponseDataItem(
            string attributeKey,
            string entityKind,
            double count)
        {
            this.AttributeKey = attributeKey ?? throw new global::System.ArgumentNullException(nameof(attributeKey));
            this.EntityKind = entityKind ?? throw new global::System.ArgumentNullException(nameof(entityKind));
            this.Count = count;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListFlagLabelCountsResponseDataItem" /> class.
        /// </summary>
        public ListFlagLabelCountsResponseDataItem()
        {
        }

    }
}