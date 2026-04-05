
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchDomainResponseVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("moved")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Moved { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchDomainResponseVariant1" /> class.
        /// </summary>
        /// <param name="moved"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchDomainResponseVariant1(
            bool moved)
        {
            this.Moved = moved;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchDomainResponseVariant1" /> class.
        /// </summary>
        public PatchDomainResponseVariant1()
        {
        }
    }
}