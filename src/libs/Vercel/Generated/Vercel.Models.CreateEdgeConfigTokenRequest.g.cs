
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateEdgeConfigTokenRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEdgeConfigTokenRequest" /> class.
        /// </summary>
        /// <param name="label"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateEdgeConfigTokenRequest(
            string label)
        {
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEdgeConfigTokenRequest" /> class.
        /// </summary>
        public CreateEdgeConfigTokenRequest()
        {
        }
    }
}