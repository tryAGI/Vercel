
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchEdgeConfigItemsRequestItemEnum3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.PatchEdgeConfigItemsRequestItemEnumOperation3JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.PatchEdgeConfigItemsRequestItemEnumOperation3 Operation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchEdgeConfigItemsRequestItemEnum3" /> class.
        /// </summary>
        /// <param name="operation"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchEdgeConfigItemsRequestItemEnum3(
            global::Vercel.PatchEdgeConfigItemsRequestItemEnumOperation3 operation)
        {
            this.Operation = operation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchEdgeConfigItemsRequestItemEnum3" /> class.
        /// </summary>
        public PatchEdgeConfigItemsRequestItemEnum3()
        {
        }
    }
}