
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LookupFlagLabelsRequestItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entityKind")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EntityKind { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributeKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AttributeKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LookupFlagLabelsRequestItem" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="entityKind"></param>
        /// <param name="attributeKey"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LookupFlagLabelsRequestItem(
            string value,
            string entityKind,
            string attributeKey)
        {
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.EntityKind = entityKind ?? throw new global::System.ArgumentNullException(nameof(entityKind));
            this.AttributeKey = attributeKey ?? throw new global::System.ArgumentNullException(nameof(attributeKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LookupFlagLabelsRequestItem" /> class.
        /// </summary>
        public LookupFlagLabelsRequestItem()
        {
        }

    }
}