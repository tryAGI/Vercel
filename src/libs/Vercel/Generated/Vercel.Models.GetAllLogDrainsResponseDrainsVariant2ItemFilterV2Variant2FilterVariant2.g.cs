
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAllLogDrainsResponseDrainsVariant2ItemFilterV2Variant2FilterVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetAllLogDrainsResponseDrainsVariant2ItemFilterV2Variant2FilterVariant2TypeJsonConverter))]
        public global::Vercel.GetAllLogDrainsResponseDrainsVariant2ItemFilterV2Variant2FilterVariant2Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAllLogDrainsResponseDrainsVariant2ItemFilterV2Variant2FilterVariant2" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAllLogDrainsResponseDrainsVariant2ItemFilterV2Variant2FilterVariant2(
            string text,
            global::Vercel.GetAllLogDrainsResponseDrainsVariant2ItemFilterV2Variant2FilterVariant2Type type)
        {
            this.Type = type;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAllLogDrainsResponseDrainsVariant2ItemFilterV2Variant2FilterVariant2" /> class.
        /// </summary>
        public GetAllLogDrainsResponseDrainsVariant2ItemFilterV2Variant2FilterVariant2()
        {
        }
    }
}