
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchEdgeConfigItemsRequestItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.PatchEdgeConfigItemsRequestItemOperationJsonConverter))]
        public global::Vercel.PatchEdgeConfigItemsRequestItemOperation? Operation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public object? Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, object>))]
        public global::Vercel.OneOf<string, object>? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchEdgeConfigItemsRequestItem" /> class.
        /// </summary>
        /// <param name="operation"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <param name="description"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchEdgeConfigItemsRequestItem(
            global::Vercel.PatchEdgeConfigItemsRequestItemOperation? operation,
            string? key,
            object? value,
            global::Vercel.OneOf<string, object>? description)
        {
            this.Operation = operation;
            this.Key = key;
            this.Value = value;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchEdgeConfigItemsRequestItem" /> class.
        /// </summary>
        public PatchEdgeConfigItemsRequestItem()
        {
        }
    }
}