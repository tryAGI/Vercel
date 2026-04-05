
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchEdgeConfigItemsRequestItemEnum
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.PatchEdgeConfigItemsRequestItemEnumOperationJsonConverter))]
        public global::Vercel.PatchEdgeConfigItemsRequestItemEnumOperation Operation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchEdgeConfigItemsRequestItemEnum" /> class.
        /// </summary>
        /// <param name="operation"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchEdgeConfigItemsRequestItemEnum(
            global::Vercel.PatchEdgeConfigItemsRequestItemEnumOperation operation)
        {
            this.Operation = operation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchEdgeConfigItemsRequestItemEnum" /> class.
        /// </summary>
        public PatchEdgeConfigItemsRequestItemEnum()
        {
        }
    }
}