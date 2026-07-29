
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchEdgeConfigItemsRequestItemEnum4
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Operation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchEdgeConfigItemsRequestItemEnum4" /> class.
        /// </summary>
        /// <param name="operation"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchEdgeConfigItemsRequestItemEnum4(
            object operation)
        {
            this.Operation = operation ?? throw new global::System.ArgumentNullException(nameof(operation));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchEdgeConfigItemsRequestItemEnum4" /> class.
        /// </summary>
        public PatchEdgeConfigItemsRequestItemEnum4()
        {
        }

    }
}