
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchEdgeConfigSchemaRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("definition")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Definition { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchEdgeConfigSchemaRequest" /> class.
        /// </summary>
        /// <param name="definition"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchEdgeConfigSchemaRequest(
            object definition)
        {
            this.Definition = definition ?? throw new global::System.ArgumentNullException(nameof(definition));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchEdgeConfigSchemaRequest" /> class.
        /// </summary>
        public PatchEdgeConfigSchemaRequest()
        {
        }
    }
}