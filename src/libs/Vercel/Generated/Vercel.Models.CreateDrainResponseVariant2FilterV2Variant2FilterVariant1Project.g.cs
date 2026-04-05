
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDrainResponseVariant2FilterV2Variant2FilterVariant1Project
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ids")]
        public global::System.Collections.Generic.IList<string>? Ids { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDrainResponseVariant2FilterV2Variant2FilterVariant1Project" /> class.
        /// </summary>
        /// <param name="ids"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDrainResponseVariant2FilterV2Variant2FilterVariant1Project(
            global::System.Collections.Generic.IList<string>? ids)
        {
            this.Ids = ids;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDrainResponseVariant2FilterV2Variant2FilterVariant1Project" /> class.
        /// </summary>
        public CreateDrainResponseVariant2FilterV2Variant2FilterVariant1Project()
        {
        }
    }
}